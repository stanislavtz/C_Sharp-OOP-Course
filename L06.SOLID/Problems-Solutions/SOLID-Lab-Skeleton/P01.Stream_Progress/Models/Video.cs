namespace Stream_Progress
{
    using System.Collections.Generic;

    public class Video : File, IStreamable
    {
        private readonly string name;
        private readonly IReadOnlyCollection<Artist> artists;

        public Video(string name, List<Artist> artists, int length, int bytesSent)
            : base(length, bytesSent)
        {
            this.name = name;
            this.artists = artists;
        }
    }
}
