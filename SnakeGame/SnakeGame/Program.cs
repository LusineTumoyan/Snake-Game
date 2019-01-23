using System;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetWindowSize(81, 21);
            Console.SetBufferSize(81, 21);

            Display.Play();

            Snake player = new Snake(3, 0, 3);

            Display.GameOver();
        }

    }
}