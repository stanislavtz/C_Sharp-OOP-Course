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
                    var authorName = songArgs[0];
                    var songName = songArgs[1];
                    var minutes = int.Parse(songArgs[2]);
                    var seconds = int.Parse(songArgs[3]);

                    var song = new Song(authorName, songName, minutes, seconds);

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
                double totalSeconds = songs.Sum(s => s.Seconds);
                double totalMinutes = songs.Sum(m => m.Minutes);
                double totalHours = 0;

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
                Console.WriteLine($"Songs added: {songs.Count}");
                Console.WriteLine($"Playlist length: {totalHours:f0}h {totalMinutes:f0}m {totalSeconds:f0}s");
            }
        }
    }
}
