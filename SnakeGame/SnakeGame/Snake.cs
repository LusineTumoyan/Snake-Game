using System;
using System.Collections.Generic;
using System.Threading;

namespace SnakeGame
{
    class Snake : IMoveable
    {
        const int x = 80;
        const int y = 20;

        List<Point> snake;
        public Point head;
        public Point tail;
        public enum Direction
        {
            Right, Left, Up, Down
        }
        Direction direction;
        int acceleration = 120;

        Point food;
        bool foodEaten = true;
        bool AteItself = false;


        public Snake(int x, int y, int length)
        {
            snake = new List<Point>();
            for (int i = x - length; i < x; i++)
            {
                snake.Add(new Point(i, y, 'O'));
                snake[i].Draw();
            }
            this.head = snake[snake.Count - 1];
            this.tail = snake[0];
            direction = Direction.Right;
            while (true)
            {
                Move();
                if (AteItself)
                {
                    Console.Clear();
                    break;
                }
            }
        }

        public void Grow()
        {
            Point eaten = new Point();
            switch (direction)
            {
                case Direction.Right:
                    eaten = new Point(tail.Xcoord - 1, tail.Ycoord, 'O');
                    break;
                case Direction.Left:
                    eaten = new Point(tail.Xcoord + 1, tail.Ycoord, 'O');
                    break;
                case Direction.Up:
                    eaten = new Point(tail.Xcoord, tail.Ycoord - 1, 'O');
                    break;
                case Direction.Down:
                    eaten = new Point(tail.Xcoord, tail.Ycoord + 1, 'O');
                    break;
            }
            eaten.Clear();
            snake.Add(eaten);
        }

        public void Move()
        {
            while (!Console.KeyAvailable && !AteItself)
            {
                switch (this.direction)
                {
                    case Direction.Right:
                        MoveRight();
                        CreateFood();
                        Thread.Sleep(acceleration);
                        break;
                    case Direction.Left:
                        MoveLeft();
                        CreateFood();
                        Thread.Sleep(acceleration);
                        break;
                    case Direction.Up:
                        MoveUp();
                        CreateFood();
                        Thread.Sleep(acceleration);
                        break;
                    case Direction.Down:
                        MoveDown();
                        CreateFood();
                        Thread.Sleep(acceleration);
                        break;
                }
                CHeckForHitItself();
                if (AteItself) return;
                EatFood();
            }
            Rotate();
        }

        public void Rotate()
        {
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.RightArrow:
                    if (this.direction != Direction.Left)
                    {
                        direction = Direction.Right;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (this.direction != Direction.Right)
                    {
                        direction = Direction.Left;
                    }
                    break;
                case ConsoleKey.UpArrow:
                    if (this.direction != Direction.Down)
                    {
                        direction = Direction.Up;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (this.direction != Direction.Up)
                    {
                        direction = Direction.Down;
                    }
                    break;
            }
        }


        #region interface
        public void MoveHelper(Point point)
        {
            this.head = point;
            this.head.Draw();
            snake.Add(this.head);

            this.tail = snake[0];
            this.tail.Clear();
            snake.Remove(tail);
        }

        public void MoveRight()
        {
            Point point = this.head;
            try
            {
                point.Xcoord++;
                if (point.Xcoord == x && point.Ycoord == y)
                {
                    point.Xcoord = 0;
                }
                MoveHelper(point);
            }
            catch (ArgumentOutOfRangeException)
            {
                point.Xcoord = 0;

                MoveHelper(point);
            }

            this.direction = Direction.Right;
        }

        public void MoveLeft()
        {
            Point point = this.head;
            try
            {
                point.Xcoord--;
                if (point.Xcoord == -1 && point.Ycoord == y)
                {
                    point.Xcoord = x - 1;
                }
                MoveHelper(point);
            }
            catch (ArgumentOutOfRangeException)
            {
                point.Xcoord = x;

                MoveHelper(point);
            }

            this.direction = Direction.Left;
        }

        public void MoveUp()
        {
            Point point = this.head;
            try
            {
                point.Ycoord--;
                if (point.Xcoord == x && point.Ycoord == -1)
                {
                    point.Ycoord = y - 1;
                }
                MoveHelper(point);
            }
            catch (ArgumentOutOfRangeException)
            {
                point.Ycoord = y;

                MoveHelper(point);
            }

            this.direction = Direction.Up;
        }

        public void MoveDown()
        {
            Point point = this.head;
            try
            {
                point.Ycoord++;
                if (point.Xcoord == x && point.Ycoord == y)
                {
                    point.Ycoord = 0;
                }
                MoveHelper(point);
            }
            catch (ArgumentOutOfRangeException)
            {
                point.Ycoord = 0;

                MoveHelper(point);
            }

            this.direction = Direction.Down;
        }
        #endregion


        public void CreateFood()
        {
            if (foodEaten == true)
            {
                food = new Point(new Random().Next(2, 79), new Random().Next(2, 19), 'O');
                for (int i = 0; i < snake.Count; i++)
                {
                    if (food.Xcoord == snake[i].Xcoord && food.Ycoord == snake[i].Ycoord)
                    {
                        CreateFood();
                        return;
                    }
                }
                food.Draw();
                foodEaten = false;
            }
        }

        public void EatFood()
        {
            if (food.Xcoord == head.Xcoord && food.Ycoord == head.Ycoord)
            {
                foodEaten = true;
                acceleration--;
                Grow();
            }
        }

        public void CHeckForHitItself()
        {
            for (int i = 0; i < snake.Count - 1; i++)
            {
                if (head.Xcoord == snake[i].Xcoord && head.Ycoord == snake[i].Ycoord)
                {
                    AteItself = true;
                    return;
                }
            }
        }
    }
}
