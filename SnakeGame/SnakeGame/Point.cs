using System;

namespace SnakeGame
{
    struct Point
    {
        public int Xcoord;
        public int Ycoord;
        public char symbol;

        public Point(int xcoord, int ycoord, char symbol)
        {
            this.Xcoord = xcoord;
            this.Ycoord = ycoord;
            this.symbol = symbol;
            Draw();
        }

        public void Draw()
        {
            Console.SetCursorPosition(this.Xcoord, this.Ycoord);
            Console.Write(this.symbol);
        }
        public void Clear()
        {
            Console.SetCursorPosition(this.Xcoord, this.Ycoord);
            Console.Write(' ');
        }
    }
}
