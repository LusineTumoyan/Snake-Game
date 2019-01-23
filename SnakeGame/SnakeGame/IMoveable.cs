using System;

namespace SnakeGame
{
    interface IMoveable
    {
        void MoveRight();
        void MoveLeft();
        void MoveUp();
        void MoveDown();
    }
}