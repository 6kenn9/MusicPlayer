using NAudio.Wave;
using System;

namespace MusicPlayer
{
    public class AudioService
    {
        private WaveOutEvent _waveOut;
        private AudioFileReader _audioFile;
        private System.Windows.Forms.Timer _timer;

        public event Action<TimeSpan> OnTrackTimeChanged;
        public event Action OnTrackFinished;

        public AudioService()
        {
            _waveOut = new WaveOutEvent();

            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 500; 
            _timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (_audioFile != null)
            {
                OnTrackTimeChanged?.Invoke(_audioFile.CurrentTime);

                if (_audioFile.CurrentTime >= _audioFile.TotalTime)
                {
                    _timer.Stop();
                    OnTrackFinished?.Invoke();
                }
            }
        }

        public void Load(string path)
        {
            Stop(); 

            try
            {
                _audioFile = new AudioFileReader(path);
                _waveOut = new WaveOutEvent();
                _waveOut.Init(_audioFile);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Помилка завантаження файлу: " + ex.Message);
            }
        }

        public void Play()
        {
            if (_audioFile != null && _waveOut != null)
            {
                _waveOut.Play();
                _timer.Start();
            }
        }

        public void Pause()
        {
            if (_waveOut != null)
            {
                _waveOut.Pause();
                _timer.Stop();
            }
        }

        public void Stop()
        {
            if (_waveOut != null)
            {
                _waveOut.Stop();
                _waveOut.Dispose();
                _waveOut = null;
            }
            if (_audioFile != null)
            {
                _audioFile.Dispose();
                _audioFile = null;
            }
            _timer.Stop();
        }

        public void Seek(TimeSpan position)
        {
            if (_audioFile != null)
            {
                if (position < TimeSpan.Zero) position = TimeSpan.Zero;
                if (position > _audioFile.TotalTime) position = _audioFile.TotalTime;

                _audioFile.CurrentTime = position;
            }
        }

        public void SetVolume(float volume)
        {
            if (_waveOut != null)
            {
                if (volume < 0f) volume = 0f;
                if (volume > 1f) volume = 1f;

                _waveOut.Volume = volume;
            }
        }

        public TimeSpan Duration
        {
            get
            {
                return _audioFile?.TotalTime ?? TimeSpan.Zero;
            }
        }
    }
}