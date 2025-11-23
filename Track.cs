using System;

namespace MusicPlayer
{
    public class Track
    {
        public string Path { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public TimeSpan Duration { get; set; }

        public Track(string path, string title, string artist, TimeSpan duration)
        {
            Path = path;
            Title = title;
            Artist = artist;
            Duration = duration;
        }

        public string DurationString
        {
            get { return Duration.ToString(@"mm\:ss"); }
        }
    }
}