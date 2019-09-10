using System;
using OnlineRadioDatabase.Exceptions;

namespace OnlineRadioDatabase.Models
{
    public class Song
    {
        private string authorName;
        private string songName;
        private int minutes;
        private int seconds;

        public Song(string authorName, string songName, int minutes, int seconds)
        {
            this.AuthorName = authorName;
            this.SongName = songName;
            this.Minutes = minutes;
            this.Seconds = seconds;

            this.ValidateSongLength(this.Minutes, this.Seconds);
        }

        public string AuthorName
        {
            get => this.authorName;
            private set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new ArgumentException(ExceptionsData.InvalidArtistNameException);
                }

                this.authorName = value;
            }
        }

        public string SongName
        {
            get => this.songName;
            private set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new ArgumentException(ExceptionsData.InvalidSongNameException);
                }

                this.songName = value;
            }
        }

        public int Minutes
        {
            get => this.minutes;
            private set
            {
                if (value < 0 || value > 14)
                {
                    throw new ArgumentException(ExceptionsData.InvalidSongMinutesException);
                }
                this.minutes = value;
            }
        }

        public int Seconds
        {
            get => this.seconds;
            private set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException(ExceptionsData.InvalidSongSecondsException);
                }

                this.seconds = value;
            }
        }

        private void ValidateSongLength(int min, int sec)
        {
            if (min < 0 || min > 14 || sec < 0 || sec > 59)
            {
                throw new ArgumentException(ExceptionsData.InvalidSongLengthException);
            }
        }
    }
}
