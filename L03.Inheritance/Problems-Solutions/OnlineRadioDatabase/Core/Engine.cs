using System;
using OnlineRadioDatabase.Models;
using OnlineRadioDatabase.Exceptions;

namespace OnlineRadioDatabase.Core
{
    public class Engine
    {
        private PlayList playList;

        public Engine()
        {
            playList = new PlayList();
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

                    playList.AddSong(song);
                    
                    Console.WriteLine("Song added.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            if (playList != null)
            {
                Console.WriteLine(playList);
            }
        }
    }
}
