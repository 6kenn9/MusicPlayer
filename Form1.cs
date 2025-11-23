using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        private AudioService audioService = new AudioService();
        private List<Track> playlist = new List<Track>(); 
        private bool isPlaying = false;
        private bool isScrolling = false; 

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
                audioService.Play();
                btnPlay.Text = "\uE769"; 
                isPlaying = true;
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

                if (!isPlaying && playlist.Count > 0)
                {
                    PlayTrack(playlist[playlist.Count - files.Length]);
                }
            }
        }
        private void AddSongToPlaylist(string filePath)
        {
            string fileName = System.IO.Path.GetFileNameWithoutExtension(filePath);
            string artist = "Unknown";
            string title = fileName;

            if (fileName.Contains("-"))
            {
                string[] parts = fileName.Split('-');
                if (parts.Length >= 2)
                {
                    artist = parts[0].Trim();
                    title = parts[1].Trim();
                }
            }

            TimeSpan duration = TimeSpan.Zero;
            try
            {
                using (var reader = new NAudio.Wave.AudioFileReader(filePath))
                {
                    duration = reader.TotalTime;
                }
            }
            catch { }

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

        private void PlayTrack(Track track)
        {
            audioService.Load(track.Path);
            audioService.Play();

            btnPlay.Text = "\uE769"; 
            isPlaying = true;
            mainTrackBar.Value = 0;

        }

        private void AudioService_OnTrackTimeChanged(TimeSpan time)
        {
            if (isScrolling) return;

            if (audioService.Duration.TotalSeconds > 0)
            {
                double percent = time.TotalSeconds / audioService.Duration.TotalSeconds;

                int value = (int)(percent * mainTrackBar.Maximum);

                if (value >= 0 && value <= mainTrackBar.Maximum)
                {
                    mainTrackBar.Invoke((MethodInvoker)(() => mainTrackBar.Value = value));
                }
            }
        }

        private void AudioService_OnTrackFinished()
        {
            this.Invoke((MethodInvoker)(() =>
            {
                if (gridPlaylist.Rows.Count == 0) return;

                int currentIndex = -1;
                if (gridPlaylist.CurrentRow != null)
                {
                    currentIndex = gridPlaylist.CurrentRow.Index;
                }

                int nextIndex = currentIndex + 1;

                if (nextIndex >= gridPlaylist.Rows.Count)
                {
                    isPlaying = false;
                    btnPlay.Text = "\uE768";
                    return;
                }

                gridPlaylist.CurrentCell = gridPlaylist.Rows[nextIndex].Cells[1];
                gridPlaylist.Rows[nextIndex].Selected = true;

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

        private void mainTrackBar_MouseDown(object sender, MouseEventArgs e) => isScrolling = true;
        private void mainTrackBar_MouseUp(object sender, MouseEventArgs e) => isScrolling = false;

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
    }
}