using System;
using System.Drawing;

namespace snake
{
    public class Game
    {
        public event EventHandler GameOver;
        public event EventHandler ScoreUpdated;

        private Snake snake;
        private Food food;
        private int score;
        private bool isGameOver;
        private int gridWidth;
        private int gridHeight;
        private const int StartX = 5;
        private const int StartY = 10;
        private const int PointsPerFood = 10;

        public Snake Snake => snake;
        public Food Food => food;
        public int Score => score;
        public bool IsGameOver => isGameOver;
        public int GridWidth => gridWidth;
        public int GridHeight => gridHeight;

        public Game(int gridWidth, int gridHeight)
        {
            this.gridWidth = gridWidth;
            this.gridHeight = gridHeight;
            InitializeGame();
        }

        private void InitializeGame()
        {
            snake = new Snake(StartX, StartY);
            food = new Food(gridWidth, gridHeight);
            food.Generate(snake);
            score = 0;
            isGameOver = false;
        }

        public void Start()
        {
            InitializeGame();
        }

        public void Update()
        {
            if (isGameOver) return;

            snake.Move();

            if (food.IsEaten(snake))
            {
                score += PointsPerFood;
                food.Generate(snake);
                OnScoreUpdated(EventArgs.Empty);
            }
            else
            {
                snake.RemoveTail();
            }

            if (CheckCollisions())
            {
                isGameOver = true;
                OnGameOver(EventArgs.Empty);
            }
        }

        private bool CheckCollisions()
        {
            Point head = snake.Head;

            if (head.X < 0 || head.X >= gridWidth || head.Y < 0 || head.Y >= gridHeight)
            {
                return true;
            }

            if (snake.CheckSelfCollision())
            {
                return true;
            }

            return false;
        }

        public void SetDirection(Point direction)
        {
            snake.SetDirection(direction);
        }

        protected virtual void OnGameOver(EventArgs e)
        {
            GameOver?.Invoke(this, e);
        }

        protected virtual void OnScoreUpdated(EventArgs e)
        {
            ScoreUpdated?.Invoke(this, e);
        }
    }
}
