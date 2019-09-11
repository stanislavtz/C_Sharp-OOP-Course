using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace OnlineRadioDatabase.Models
{
    public class PlayList
    {
        private List<Song> playList;

        private int hours;
        private int minutes;
        private int seconds;

        public PlayList()
        {
            this.playList = new List<Song>();
        }

        public void AddSong(Song song)
        {
            this.playList.Add(song);
        }       

        private string CalculatePlayListLength()
        {
            this.minutes = this.playList.Sum(m => m.Minutes);
            this.seconds = this.playList.Sum(s => s.Seconds);

            if (this.seconds > 59)
            {
                this.minutes += this.seconds / 60;
                this.seconds %= 60;

                if (this.minutes > 59)
                {
                    this.hours += this.minutes / 60;
                    this.minutes %= 60;
                }
            }

            return $"{this.hours}h {this.minutes}m {this.seconds}s";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Songs added: {this.playList.Count}");
            sb.AppendLine($"Playlist length: {CalculatePlayListLength()}");

            return sb.ToString().TrimEnd(); 
        }
    }
}
