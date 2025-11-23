using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib.Matroska;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;        
using Newtonsoft.Json;   

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        private AudioService audioService = new AudioService();
        private bool isPlaying = false;
<<<<<<< HEAD
=======
        private List<Track> playlist = new List<Track>();
        private float lastVolume = 0.5f;
        private bool isMuted = false;
>>>>>>> d3ae185d3dc7236cf03bec36efad48d569045da7
        public Form1()
        {
            InitializeComponent();
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

                audioService.Load(files[0]);
                mainTrackBar.Maximum = 1000;
                mainTrackBar.Value = 0;
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
        private void AudioService_OnTrackTimeChanged(TimeSpan time)
        {
            Console.WriteLine("Поточний час: " + time.ToString(@"mm\:ss"));
            if (audioService.Duration.TotalSeconds > 0)
            {
                double percent = time.TotalSeconds / audioService.Duration.TotalSeconds;
                int value = (int)(percent * mainTrackBar.Maximum);

                if (value >= 0 && value <= mainTrackBar.Maximum)
                    mainTrackBar.Value = value;
            }
        }
        private void AddSongToPlaylist(string filePath)
        {
<<<<<<< HEAD
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

            using (var reader = new NAudio.Wave.AudioFileReader(filePath))
            {
                string duration = reader.TotalTime.ToString(@"mm\:ss");
                int index = gridPlaylist.Rows.Add(
                    gridPlaylist.Rows.Count + 1,
                    title,
                    artist,
                    duration
                );
=======
            string title = System.IO.Path.GetFileNameWithoutExtension(filePath);
            string artist = "Unknown Artist";
            TimeSpan duration = TimeSpan.Zero;

            try
            {
                var tfile = TagLib.File.Create(filePath);

                if (!string.IsNullOrWhiteSpace(tfile.Tag.Title))
                {
                    title = tfile.Tag.Title;
                }

                if (!string.IsNullOrWhiteSpace(tfile.Tag.FirstPerformer))
                {
                    artist = tfile.Tag.FirstPerformer;
                }

                duration = tfile.Properties.Duration;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка читання тегів: " + ex.Message);
            }
>>>>>>> d3ae185d3dc7236cf03bec36efad48d569045da7

                gridPlaylist.Rows[index].Tag = filePath;

<<<<<<< HEAD
            }
=======
            playlist.Add(newTrack);

            int index = gridPlaylist.Rows.Add(
                gridPlaylist.Rows.Count + 1,
                newTrack.Title,
                newTrack.Artist,
                newTrack.DurationString
            );

            gridPlaylist.Rows[index].Tag = newTrack;
>>>>>>> d3ae185d3dc7236cf03bec36efad48d569045da7
        }

        private void mainTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            double percent = (double)mainTrackBar.Value / mainTrackBar.Maximum;

            TimeSpan newPosition = TimeSpan.FromSeconds(
                audioService.Duration.TotalSeconds * percent
            );

            audioService.Seek(newPosition);
<<<<<<< HEAD
        }
        private void AudioService_OnTrackFinished()
        {
            if (gridPlaylist.Rows.Count == 0)
                return;

            int currentIndex = -1;

            if (gridPlaylist.CurrentRow != null)
                currentIndex = gridPlaylist.CurrentRow.Index;

            if (currentIndex == -1)
                currentIndex = 0;

            int nextIndex = currentIndex + 1;

            if (nextIndex >= gridPlaylist.Rows.Count)
            {
                isPlaying = false;
                btnPlay.Text = "\uE768";
                return;
            }

            gridPlaylist.CurrentCell = gridPlaylist.Rows[nextIndex].Cells[1];

            string title = gridPlaylist.Rows[nextIndex].Cells[1].Value.ToString();
            string artist = gridPlaylist.Rows[nextIndex].Cells[2].Value.ToString();

            string filePath = gridPlaylist.Rows[nextIndex].Tag.ToString();

            audioService.Load(filePath);
            audioService.Play();

            btnPlay.Text = "\uE769";
            isPlaying = true;
=======
        }
        private void AudioService_OnTrackFinished()
        {
            if (gridPlaylist.Rows.Count == 0)
                return;

            int currentIndex = -1;

            if (gridPlaylist.CurrentRow != null)
                currentIndex = gridPlaylist.CurrentRow.Index;

            if (currentIndex == -1)
                currentIndex = 0;

            int nextIndex = currentIndex + 1;

            if (nextIndex >= gridPlaylist.Rows.Count)
            {
                isPlaying = false;
                btnPlay.Text = "\uE768";
                return;
            }

            gridPlaylist.CurrentCell = gridPlaylist.Rows[nextIndex].Cells[1];

            string title = gridPlaylist.Rows[nextIndex].Cells[1].Value.ToString();
            string artist = gridPlaylist.Rows[nextIndex].Cells[2].Value.ToString();

            string filePath = gridPlaylist.Rows[nextIndex].Tag.ToString();

            audioService.Load(filePath);
            audioService.Play();

            btnPlay.Text = "\uE769";
            isPlaying = true;
        }

        private void savePlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Playlist Files|*.json";
            saveDialog.Title = "Зберегти плейлист";
            saveDialog.FileName = "MyPlaylist.json";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string json = JsonConvert.SerializeObject(playlist, Formatting.Indented);
                    System.IO.File.WriteAllText(saveDialog.FileName, json);

                    MessageBox.Show("Плейлист успішно збережено!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка збереження: " + ex.Message);
                }
            }
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

        private void loadPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Playlist Files|*.json";
            openDialog.Title = "Відкрити плейлист";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string json = System.IO.File.ReadAllText(openDialog.FileName);

                    List<Track> loadedTracks = JsonConvert.DeserializeObject<List<Track>>(json);

                    playlist.Clear();
                    gridPlaylist.Rows.Clear(); 

                    if (loadedTracks != null)
                    {
                        foreach (Track track in loadedTracks)
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

                    MessageBox.Show($"Завантажено {playlist.Count} треків.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка відкриття плейлиста: " + ex.Message);
                }
            }
        }

        private void trackBarVolume_Scroll(object sender, ScrollEventArgs e)
        {
            float volume = (float)trackBarVolume.Value / trackBarVolume.Maximum;
            audioService.SetVolume(volume);

            if (!isMuted)
                lastVolume = volume;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (!isMuted)
            {
                lastVolume = (float)trackBarVolume.Value / trackBarVolume.Maximum;
                audioService.SetVolume(0f);
                trackBarVolume.Value = 0;

                guna2CircleButton1.Text = "\uE992";
                isMuted = true;
            }
            else
            {
                audioService.SetVolume(lastVolume);
                trackBarVolume.Value = (int)(lastVolume * trackBarVolume.Maximum);

                guna2CircleButton1.Text = "\uE995";
                isMuted = false;
            }
>>>>>>> d3ae185d3dc7236cf03bec36efad48d569045da7
        }

    }
}
