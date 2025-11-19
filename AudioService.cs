using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace MusicPlayer
{
    class AudioService
    {
        private WaveOutEvent _waveOut;

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
    }
}
