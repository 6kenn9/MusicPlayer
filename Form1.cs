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

            StylePlaylist();

            gridPlaylist.Rows.Add("1", "Billie Jean", "Michael Jackson", "4:54");
            gridPlaylist.Rows.Add("2", "Smells Like Teen Spirit", "Nirvana", "5:01");
            gridPlaylist.Rows.Add("3", "Shape of You", "Ed Sheeran", "3:53");
            gridPlaylist.Rows.Add("4", "Blinding Lights", "The Weeknd", "3:20");
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                btnPlay.Text = "\uE768";

                isPlaying = false;

                Console.WriteLine("Backend: Music Paused"); 
            }
            else
            {

                btnPlay.Text = "\uE769";

                isPlaying = true;

                Console.WriteLine("Backend: Music Playing"); 
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

                audioService.Load(files[0]);
                audioService.Play();

                foreach (string f in files)
                    Console.WriteLine(f);
            }
        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {

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
    }
}
