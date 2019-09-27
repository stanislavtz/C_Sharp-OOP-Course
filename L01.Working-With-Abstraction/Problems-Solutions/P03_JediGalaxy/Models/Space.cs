namespace P03_JediGalaxy.Models
{
    public class Space
    {
        public Space(int row, int col)
        {
            this.SpaceDimentions = new int[row, col];
            this.SpaceCreate(row, col);
        }

        public int[,] SpaceDimentions { get; private set; }

        private int[,] SpaceCreate(int row, int col)
        {
            this.SpaceDimentions = new int[row, col];

            int value = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    this.SpaceDimentions[i, j] = value++;
                }
            }

            return this.SpaceDimentions;
        }
    }
}
