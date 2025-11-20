using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        private AudioService audioService = new AudioService();
        private bool isPlaying = false;
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

                // зберігаємо шлях файлу
                gridPlaylist.Rows[index].Tag = filePath;

            }
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
            // якщо немає треків — нічого не робимо
            if (gridPlaylist.Rows.Count == 0)
                return;

            // поточно вибраний рядок
            int currentIndex = -1;

            if (gridPlaylist.CurrentRow != null)
                currentIndex = gridPlaylist.CurrentRow.Index;

            // якщо нічого не вибрано — починаємо з першого
            if (currentIndex == -1)
                currentIndex = 0;

            // індекс наступного треку
            int nextIndex = currentIndex + 1;

            // якщо наступного треку немає — зупиняємо плеєр
            if (nextIndex >= gridPlaylist.Rows.Count)
            {
                isPlaying = false;
                btnPlay.Text = "\uE768"; // play icon
                return;
            }

            // вибираємо наступний рядок
            gridPlaylist.CurrentCell = gridPlaylist.Rows[nextIndex].Cells[1];

            // отримуємо назву файла з DataGrid (потрібно зберегти шлях)
            string title = gridPlaylist.Rows[nextIndex].Cells[1].Value.ToString();
            string artist = gridPlaylist.Rows[nextIndex].Cells[2].Value.ToString();

            // ЗНАЧНО ПРОСТІШЕ — зберігати шлях у Tag:
            string filePath = gridPlaylist.Rows[nextIndex].Tag.ToString();

            audioService.Load(filePath);
            audioService.Play();

            btnPlay.Text = "\uE769";
            isPlaying = true;
        }

    }
}
