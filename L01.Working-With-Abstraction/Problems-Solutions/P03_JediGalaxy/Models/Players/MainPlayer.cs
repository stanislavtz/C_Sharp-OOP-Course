namespace P03_JediGalaxy.Models.Players
{
    public class MainPlayer : Player
    {
        public MainPlayer(int row, int col, long collectedStars)
            : base(row, col)
        {
            this.CollectedStars = collectedStars;
        }

        public long CollectedStars { get; private set; }

        public override void Move(Space space, int initialRow, int initialCol)
        {
            var matrix = space.SpaceDimentions;

            while (this.Row >= 0 && this.Col < matrix.GetLength(1))
            {
                if (this.Row >= 0 && this.Row < matrix.GetLength(0) && this.Col >= 0 && this.Col < matrix.GetLength(1))
                {
                    this.CollectedStars += matrix[this.Row, this.Col];
                }

                this.Col++;
                this.Row--;
            }
        }

        public override string ToString()
        {
            return this.CollectedStars.ToString();
        }
    }
}
