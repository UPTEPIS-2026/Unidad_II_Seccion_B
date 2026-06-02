using System;
using System.Collections.Generic;
using System.Drawing;

namespace snake
{
    public class Snake
    {
        private List<Point> body;
        private Point direction;
        private const int InitialLength = 3;

        public List<Point> Body => body;
        public Point Head => body[0];
        public int Length => body.Count;

        public Snake(int startX, int startY)
        {
            body = new List<Point>();
            for (int i = 0; i < InitialLength; i++)
            {
                body.Add(new Point(startX - i, startY));
            }
            direction = new Point(1, 0);
        }

        public void SetDirection(Point newDirection)
        {
            if (newDirection.X != -direction.X || newDirection.Y != -direction.Y)
            {
                direction = newDirection;
            }
        }

        public void Move()
        {
            Point newHead = new Point(Head.X + direction.X, Head.Y + direction.Y);
            body.Insert(0, newHead);
        }

        public void RemoveTail()
        {
            if (body.Count > 0)
            {
                body.RemoveAt(body.Count - 1);
            }
        }

        public bool CheckSelfCollision()
        {
            for (int i = 1; i < body.Count; i++)
            {
                if (body[i] == Head)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Contains(Point point)
        {
            return body.Contains(point);
        }
    }
}
