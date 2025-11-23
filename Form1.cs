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

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        private AudioService audioService = new AudioService();
        private bool isPlaying = false;
        private List<Track> playlist = new List<Track>();   
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

        private void mainTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            double percent = (double)mainTrackBar.Value / mainTrackBar.Maximum;

            TimeSpan newPosition = TimeSpan.FromSeconds(
                audioService.Duration.TotalSeconds * percent
            );

            audioService.Seek(newPosition);
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

    }
}
