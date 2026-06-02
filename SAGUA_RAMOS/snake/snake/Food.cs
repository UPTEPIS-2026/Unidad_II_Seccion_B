using System;
using System.Drawing;

namespace snake
{
    public class Food
    {
        private Point position;
        private Random random;
        private int gridWidth;
        private int gridHeight;

        public Point Position => position;

        public Food(int gridWidth, int gridHeight)
        {
            this.gridWidth = gridWidth;
            this.gridHeight = gridHeight;
            random = new Random();
        }

        public void Generate(Snake snake)
        {
            bool validPosition = false;
            while (!validPosition)
            {
                position = new Point(random.Next(0, gridWidth), random.Next(0, gridHeight));
                validPosition = !snake.Contains(position);
            }
        }

        public bool IsEaten(Snake snake)
        {
            return snake.Head == position;
        }
    }
}
