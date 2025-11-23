using NAudio.Wave;
using System;

namespace MusicPlayer
{
    class AudioService
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
<<<<<<< HEAD
            _timer.Interval = 500;
=======
            _timer.Interval = 499;
>>>>>>> d3ae185d3dc7236cf03bec36efad48d569045da7
            _timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, System.EventArgs e)
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

        public void SetVolume(float volume)
        {
            if (_waveOut == null) return;

            if (volume < 0f) volume = 0f;
            if (volume > 1f) volume = 1f;

            _waveOut.Volume = volume;
        }

        public void Load(string path)
        {
            if (_waveOut != null)
            {
                _waveOut.Stop();
                _waveOut.Dispose();
            }

            if (_audioFile != null)
            {
                _audioFile.Dispose();
            }

            _waveOut = new WaveOutEvent();
            _audioFile = new AudioFileReader(path);

            _waveOut.Init(_audioFile);
        }

        public void Play()
        {
            if (_audioFile == null) return;

            _waveOut.Play();
            _timer.Start();
        }
        public void Pause()
        {
            if (_audioFile == null) return;

            _waveOut.Pause();
            _timer.Stop();
        }
        public void Seek(TimeSpan position)
        {
            if (_audioFile == null) return;

            if (position < TimeSpan.Zero)
                position = TimeSpan.Zero;

            if (position > _audioFile.TotalTime)
                position = _audioFile.TotalTime;

            _audioFile.CurrentTime = position;
        }
        public TimeSpan Duration
        {
            get
            {
                if (_audioFile == null) return TimeSpan.Zero;
                return _audioFile.TotalTime;
            }
        }

    }
}
