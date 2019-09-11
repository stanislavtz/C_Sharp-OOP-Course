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
            playList = new List<Song>();
        }

        public void AddSong(Song song)
        {
            playList.Add(song);
        }       

        private string CalculatePlayListLength()
        {
            hours = 0;
            minutes = playList.Sum(m => m.Minutes);
            seconds = playList.Sum(s => s.Seconds);

            if (seconds > 59)
            {
                minutes += seconds / 60;
                seconds %= 60;

                if (minutes > 59)
                {
                    hours += minutes / 60;
                    minutes %= 60;
                }
            }

            return $"{hours}h {minutes}m {seconds}s";
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
