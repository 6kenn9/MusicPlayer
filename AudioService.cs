using NAudio.Wave;

namespace MusicPlayer
{
    class AudioService
    {
        private WaveOutEvent _waveOut;
        private AudioFileReader _audioFile;

        public AudioService()
        {
            _waveOut = new WaveOutEvent();
        }

        public void SetVolume(float volume)
        {
            if (_waveOut == null)
                return;

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
        }
    }
}
