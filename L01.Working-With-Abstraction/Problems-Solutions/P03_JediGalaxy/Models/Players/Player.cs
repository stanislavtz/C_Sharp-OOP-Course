namespace P03_JediGalaxy.Models
{
    public abstract class Player
    {
        public Player(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }

        public int Row { get; protected set; }

        public int Col { get; protected set; }

        public abstract void Move(Space space, int initialRow, int initialCol);
    }
}
