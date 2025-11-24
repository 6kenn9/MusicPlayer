using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using NAudio.Wave; 

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        private AudioService audioService = new AudioService();
        private bool isPlaying = false;
        private List<Track> playlist = new List<Track>();

        private float lastVolume = 0.5f;
        private bool isMuted = false;

        public Form1()
        {
            InitializeComponent();

            StylePlaylist();

            audioService.OnTrackTimeChanged += AudioService_OnTrackTimeChanged;
            audioService.OnTrackFinished += AudioService_OnTrackFinished;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (!isPlaying)
            {
                if (audioService.Duration == TimeSpan.Zero && playlist.Count > 0)
                {
                    PlayTrack(playlist[0]);
                }
                else
                {
                    audioService.Play();
                    btnPlay.Text = "\uE769"; 
                    isPlaying = true;
                }
            }
            else
            {
                audioService.Pause();
                btnPlay.Text = "\uE768"; 
                isPlaying = false;
            }
        }

        private void завантажитиПіснюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            dlg.Filter = "Audio files (*.mp3;*.wav)|*.mp3;*.wav";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string[] files = dlg.FileNames;

                foreach (string file in files)
                {
                    AddSongToPlaylist(file);
                }

                if (!isPlaying && playlist.Count > 0 && audioService.Duration == TimeSpan.Zero)
                {
                }
            }
        }

        private void AddSongToPlaylist(string filePath)
        {
            string title = System.IO.Path.GetFileNameWithoutExtension(filePath);
            string artist = "Unknown Artist";
            TimeSpan duration = TimeSpan.Zero;

            try
            {
                var tfile = TagLib.File.Create(filePath);

                if (!string.IsNullOrWhiteSpace(tfile.Tag.Title))
                    title = tfile.Tag.Title;

                if (!string.IsNullOrWhiteSpace(tfile.Tag.FirstPerformer))
                    artist = tfile.Tag.FirstPerformer;

                duration = tfile.Properties.Duration;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка читання тегів: " + ex.Message);
            }

            Track newTrack = new Track(filePath, title, artist, duration);

            playlist.Add(newTrack);

            int index = gridPlaylist.Rows.Add(
                gridPlaylist.Rows.Count + 1, 
                newTrack.Title,
                newTrack.Artist,
                newTrack.DurationString
            );

            gridPlaylist.Rows[index].Tag = newTrack;
        }

        private Image GetAlbumArt(string filePath)
        {
            try
            {
                var file = TagLib.File.Create(filePath);
                if (file.Tag.Pictures.Length > 0)
                {
                    var bin = (byte[])file.Tag.Pictures[0].Data.Data;
                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream(bin))
                    {
                        return Image.FromStream(ms);
                    }
                }
            }
            catch { }
            return null; 
        }

        private void PlayTrack(Track track)
        {
            audioService.Load(track.Path);
            audioService.Play();

            isPlaying = true;
            btnPlay.Text = "\uE769";
            mainTrackBar.Value = 0;

        }

        private void AudioService_OnTrackTimeChanged(TimeSpan time)
        {
            this.Invoke((MethodInvoker)(() =>
            {
                if (audioService.Duration.TotalSeconds > 0)
                {
                    double percent = time.TotalSeconds / audioService.Duration.TotalSeconds;
                    int value = (int)(percent * mainTrackBar.Maximum);

                    if (value >= 0 && value <= mainTrackBar.Maximum)
                        mainTrackBar.Value = value;
                }
            }));
        }

        private void AudioService_OnTrackFinished()
        {
            this.Invoke((MethodInvoker)(() =>
            {
                if (gridPlaylist.Rows.Count == 0) return;

                int currentIndex = -1;
                if (gridPlaylist.CurrentRow != null)
                    currentIndex = gridPlaylist.CurrentRow.Index;

                int nextIndex = currentIndex + 1;

                if (nextIndex >= gridPlaylist.Rows.Count)
                {
                    isPlaying = false;
                    btnPlay.Text = "\uE768"; 
                    return;
                }

                gridPlaylist.CurrentCell = gridPlaylist.Rows[nextIndex].Cells[1];

                if (gridPlaylist.Rows[nextIndex].Tag is Track nextTrack)
                {
                    PlayTrack(nextTrack);
                }
            }));
        }

        private void mainTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            if (audioService.Duration.TotalSeconds > 0)
            {
                double percent = (double)mainTrackBar.Value / mainTrackBar.Maximum;
                TimeSpan newPosition = TimeSpan.FromSeconds(audioService.Duration.TotalSeconds * percent);
                audioService.Seek(newPosition);
            }
        }

        private void trackBarVolume_Scroll(object sender, ScrollEventArgs e)
        {
            float volume = (float)trackBarVolume.Value / trackBarVolume.Maximum;
            audioService.SetVolume(volume);

            if (!isMuted) lastVolume = volume;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e) 
        {
            if (!isMuted)
            {
                lastVolume = (float)trackBarVolume.Value / trackBarVolume.Maximum;
                audioService.SetVolume(0f);
                trackBarVolume.Value = 0;

                isMuted = true;
            }
            else
            {
                audioService.SetVolume(lastVolume);
                trackBarVolume.Value = (int)(lastVolume * trackBarVolume.Maximum);

                isMuted = false;
            }
        }

        private void savePlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Playlist Files|*.json";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string json = JsonConvert.SerializeObject(playlist, Formatting.Indented);
                    File.WriteAllText(saveDialog.FileName, json);
                    MessageBox.Show("Збережено!");
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }

        private void loadPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Playlist Files|*.json";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string json = File.ReadAllText(openDialog.FileName);
                    var loadedTracks = JsonConvert.DeserializeObject<List<Track>>(json);

                    if (loadedTracks != null)
                    {
                        playlist.Clear();
                        gridPlaylist.Rows.Clear();

                        foreach (var track in loadedTracks)
                        {
                            playlist.Add(track);
                            int index = gridPlaylist.Rows.Add(
                                gridPlaylist.Rows.Count + 1,
                                track.Title,
                                track.Artist,
                                track.DurationString
                            );
                            gridPlaylist.Rows[index].Tag = track;
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }

        private void StylePlaylist()
        {
            gridPlaylist.BackgroundColor = Color.FromArgb(18, 18, 18);
            gridPlaylist.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(18, 18, 18);
            gridPlaylist.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(25, 25, 25);
            gridPlaylist.ThemeStyle.RowsStyle.ForeColor = Color.White;
            gridPlaylist.ColumnHeadersHeight = 40;
            gridPlaylist.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(35, 35, 35);
            gridPlaylist.ThemeStyle.HeaderStyle.ForeColor = Color.LightGray;
            gridPlaylist.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            gridPlaylist.RowTemplate.Height = 45;
            gridPlaylist.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            gridPlaylist.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            gridPlaylist.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            gridPlaylist.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridPlaylist.ThemeStyle.GridColor = Color.FromArgb(50, 50, 50);
            gridPlaylist.RowHeadersVisible = false;
            gridPlaylist.BorderStyle = BorderStyle.None;
            gridPlaylist.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridPlaylist.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }
        private void gridPlaylist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && gridPlaylist.Rows[e.RowIndex].Tag is Track t)
            {
                PlayTrack(t);
            }
        }
    }
}