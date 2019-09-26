namespace Stream_Progress
{
    public class File : IStreamable
    {
        private string name;

        public File(int length, int bytesSent)
        {
            this.Length = length;
            this.BytesSent = bytesSent;
        }

        public File(string name, int length, int bytesSent) 
            :this(length, bytesSent)
        {
            this.name = name;
        }

        public int Length { get; set; }

        public int BytesSent { get; set; }
    }
}
