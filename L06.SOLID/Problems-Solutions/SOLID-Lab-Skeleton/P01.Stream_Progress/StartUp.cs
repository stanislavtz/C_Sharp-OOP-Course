namespace Stream_Progress
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            List<IStreamable> filesCollection = new List<IStreamable>();

            IStreamable stream;

            List<Artist> artistArgs = new List<Artist>
            {
                new Artist("JJ", 34, "Male"),
                new Artist("FF", 23, "Female"),
                new Artist("KK", 12, "Kid")
            };

            stream = new File("file1", 345, 203);
            filesCollection.Add(stream);

            stream = new Music("file1", "alabala", 1230, 1230);
            filesCollection.Add(stream);

            stream = new Video("file1", artistArgs, 3450, 2235);
            filesCollection.Add(stream);

            foreach (var file in filesCollection)
            {
                var streamProgress = new StreamProgressInfo(file);

                Console.WriteLine($"{streamProgress.CalculateCurrentPercent()}");
            }
        }
    }
}
