namespace P03_JediGalaxy.Models.Players
{
    public class EvilPlayer : Player
    {
        public EvilPlayer(int row, int col) 
            : base(row, col)
        {
        }

        public override void Move(Space space, int initialRow, int initialCol)
        {
            var matrix = space.SpaceDimentions;

            while (this.Row >= 0 && this.Col >= 0)
            {
                if (this.Row >= 0 && this.Row < matrix.GetLength(0) && this.Col >= 0 && this.Col < matrix.GetLength(1))
                {
                    matrix[this.Row, this.Col] = 0;
                }

                this.Row--;
                this.Col--;
            }
        }
    }
}
