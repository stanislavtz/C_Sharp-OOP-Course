using System;
using System.Collections.Generic;
using System.Linq;
using OnlineRadioDatabase.Exceptions;
using OnlineRadioDatabase.Models;

namespace OnlineRadioDatabase.Core
{
    public class Engine
    {
        private List<Song> songs;

        public Engine()
        {
            songs = new List<Song>();
        }

        public void Run()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] songArgs = Console.ReadLine()
                    .Split(new char[] { ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

                if (songArgs.Length != 4)
                {
                    throw new ArgumentException(ExceptionsData.InvalidSongException);
                }

                try
                {
                    string artistName = songArgs[0];
                    string songName = songArgs[1];
                    string tempMinutes = songArgs[2];
                    string tempSeconds = songArgs[3];

                    bool isMinutes = int.TryParse(songArgs[2], out int minutes);
                    bool isSeconds = int.TryParse(songArgs[3], out int seconds);

                    if (!isMinutes || !isSeconds || tempMinutes.Contains(" ") || tempSeconds.Contains(" "))
                    {
                        throw new ArgumentException(ExceptionsData.InvalidSongLengthException);
                    }

                    var song = new Song(artistName, songName, minutes, seconds);

                    songs.Add(song);
                    Console.WriteLine("Song added.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            if (songs != null)
            {
                double totalSeconds, totalMinutes, totalHours;

                CalculateTotalPlaylistTime(out totalSeconds, out totalMinutes, out totalHours);

                Console.WriteLine($"Songs added: {songs.Count}");
                Console.WriteLine($"Playlist length: {totalHours:f0}h {totalMinutes:f0}m {totalSeconds:f0}s");
            }
        }

        private void CalculateTotalPlaylistTime(out double totalSeconds, out double totalMinutes, out double totalHours)
        {
            totalSeconds = songs.Sum(s => s.Seconds);
            totalMinutes = songs.Sum(m => m.Minutes);
            totalHours = 0;
            if (totalSeconds > 59)
            {
                totalMinutes += totalSeconds / 60;
                totalSeconds %= 60;

                if (totalMinutes > 59)
                {
                    totalHours += totalMinutes / 60.0;
                    totalMinutes %= 60.0;
                }
            }
        }
    }
}
