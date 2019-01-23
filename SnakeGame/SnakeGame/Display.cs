using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    static class Display
    {
        public static void Play()
        {
            char[,] play = new char[5, 18];
            for (int i = 0; i < play.GetLength(0); i++)
            {
                for (int j = 0; j < play.GetLength(1); j++)
                {
                    play[i, j] = ' ';
                }
            }
            Console.SetCursorPosition(32, 12);
            Console.WriteLine("Press enter to start!");

            #region initialize
            play[0, 0] = '#';
            play[1, 0] = '#';
            play[2, 0] = '#';
            play[3, 0] = '#';
            play[4, 0] = '#';
            play[0, 1] = '#';
            play[2, 1] = '#';
            play[0, 2] = '#';
            play[1, 2] = '#';
            play[2, 2] = '#';
            play[0, 4] = '#';
            play[1, 4] = '#';
            play[2, 4] = '#';
            play[3, 4] = '#';
            play[4, 4] = '#';
            play[4, 5] = '#';
            play[4, 6] = '#';
            play[0, 8] = '#';
            play[1, 8] = '#';
            play[2, 8] = '#';
            play[3, 8] = '#';
            play[4, 8] = '#';
            play[0, 9] = '#';
            play[2, 9] = '#';
            play[0, 10] = '#';
            play[1, 10] = '#';
            play[2, 10] = '#';
            play[3, 10] = '#';
            play[4, 10] = '#';
            play[0, 12] = '#';
            play[1, 12] = '#';
            play[2, 12] = '#';
            play[4, 12] = '#';
            play[2, 13] = '#';
            play[4, 13] = '#';
            play[0, 14] = '#';
            play[1, 14] = '#';
            play[2, 14] = '#';
            play[3, 14] = '#';
            play[4, 14] = '#';
            play[0, 17] = '#';
            play[1, 17] = '#';
            play[2, 17] = '#';
            play[4, 17] = '#';
            #endregion

            Console.CursorVisible = false;
            bool? c = true;
            while (!Console.KeyAvailable)
            {
                if (c == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    c = false;
                }
                else if (c == false)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    c = null;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    c = true;
                }

                for (int k = 0; k < 2 * play.GetLength(1); k += 2)
                {
                    Console.SetCursorPosition(25 + k, 4);

                    for (int i = 0; i < play.GetLength(0); i++)
                    {
                        if (play[i, k / 2] == '#')
                        {
                            Console.SetCursorPosition(25 + k, i + 4);
                            Console.Write('#');
                        }
                    }
                }
            }

            if (Console.ReadKey(true).Key == ConsoleKey.Enter)
            {
                Console.Clear();
            }
            else
            {
                Play();
            }
        }

        public static void GameOver()
        {
            char[,] gameOver = new char[5, 36];
            for (int i = 0; i < gameOver.GetLength(0); i++)
            {
                for (int j = 0; j < gameOver.GetLength(1); j++)
                {
                    gameOver[i, j] = ' ';
                }
            }
            Console.SetCursorPosition(32, 12);
            Console.WriteLine("Press R to restart!");

            #region initialize
            gameOver[0, 0] = '#';
            gameOver[1, 0] = '#';
            gameOver[2, 0] = '#';
            gameOver[3, 0] = '#';
            gameOver[4, 0] = '#';
            gameOver[0, 1] = '#';
            gameOver[2, 1] = '#';
            gameOver[4, 1] = '#';
            gameOver[0, 2] = '#';
            gameOver[2, 2] = '#';
            gameOver[3, 2] = '#';
            gameOver[4, 2] = '#';

            gameOver[0, 4] = '#';
            gameOver[1, 4] = '#';
            gameOver[2, 4] = '#';
            gameOver[3, 4] = '#';
            gameOver[4, 4] = '#';
            gameOver[0, 5] = '#';
            gameOver[2, 5] = '#';
            gameOver[0, 6] = '#';
            gameOver[1, 6] = '#';
            gameOver[2, 6] = '#';
            gameOver[3, 6] = '#';
            gameOver[4, 6] = '#';

            gameOver[0, 8] = '#';
            gameOver[1, 8] = '#';
            gameOver[2, 8] = '#';
            gameOver[3, 8] = '#';
            gameOver[4, 8] = '#';
            gameOver[0, 9] = '#';
            gameOver[0, 10] = '#';
            gameOver[1, 10] = '#';
            gameOver[2, 10] = '#';
            gameOver[3, 10] = '#';
            gameOver[4, 10] = '#';
            gameOver[0, 11] = '#';
            gameOver[0, 12] = '#';
            gameOver[1, 12] = '#';
            gameOver[2, 12] = '#';
            gameOver[3, 12] = '#';
            gameOver[4, 12] = '#';

            gameOver[0, 14] = '#';
            gameOver[1, 14] = '#';
            gameOver[2, 14] = '#';
            gameOver[3, 14] = '#';
            gameOver[4, 14] = '#';
            gameOver[0, 15] = '#';
            gameOver[2, 15] = '#';
            gameOver[4, 15] = '#';
            gameOver[0, 16] = '#';
            gameOver[2, 16] = '#';
            gameOver[4, 16] = '#';

            gameOver[0, 19] = '#';
            gameOver[1, 19] = '#';
            gameOver[2, 19] = '#';
            gameOver[3, 19] = '#';
            gameOver[4, 19] = '#';
            gameOver[0, 20] = '#';
            gameOver[4, 20] = '#';
            gameOver[0, 21] = '#';
            gameOver[1, 21] = '#';
            gameOver[2, 21] = '#';
            gameOver[3, 21] = '#';
            gameOver[4, 21] = '#';

            gameOver[0, 23] = '#';
            gameOver[1, 23] = '#';
            gameOver[2, 23] = '#';
            gameOver[3, 23] = '#';
            gameOver[3, 24] = '#';
            gameOver[4, 24] = '#';
            gameOver[0, 25] = '#';
            gameOver[1, 25] = '#';
            gameOver[2, 25] = '#';
            gameOver[3, 25] = '#';

            gameOver[0, 27] = '#';
            gameOver[1, 27] = '#';
            gameOver[2, 27] = '#';
            gameOver[3, 27] = '#';
            gameOver[4, 27] = '#';
            gameOver[0, 28] = '#';
            gameOver[2, 28] = '#';
            gameOver[4, 28] = '#';
            gameOver[0, 29] = '#';
            gameOver[2, 29] = '#';
            gameOver[4, 29] = '#';

            gameOver[0, 31] = '#';
            gameOver[1, 31] = '#';
            gameOver[2, 31] = '#';
            gameOver[3, 31] = '#';
            gameOver[4, 31] = '#';
            gameOver[0, 32] = '#';
            gameOver[2, 32] = '#';
            gameOver[3, 32] = '#';
            gameOver[0, 33] = '#';
            gameOver[1, 33] = '#';
            gameOver[2, 33] = '#';
            gameOver[4, 33] = '#';

            gameOver[0, 35] = '#';
            gameOver[1, 35] = '#';
            gameOver[2, 35] = '#';
            gameOver[4, 35] = '#';

            #endregion

            Console.CursorVisible = false;
            bool? c = true;
            while (!Console.KeyAvailable)
            {
                if (c == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    c = false;
                }
                else if (c == false)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    c = null;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    c = true;
                }

                for (int k = 0; k < 2 * gameOver.GetLength(1); k += 2)
                {
                    Console.SetCursorPosition(7 + k, 4);

                    for (int i = 0; i < gameOver.GetLength(0); i++)
                    {
                        if (gameOver[i, k / 2] == '#')
                        {
                            Console.SetCursorPosition(7 + k, i + 4);
                            Console.Write('#');
                        }
                    }
                }
            }
            if (Console.ReadKey(true).Key == ConsoleKey.R)
            {
                Console.Clear();
                Snake player = new Snake(3, 0, 3);
                GameOver();
            }
            else
            {
                GameOver();
            }
        }
    }
}
