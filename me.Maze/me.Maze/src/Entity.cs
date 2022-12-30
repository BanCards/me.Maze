using System;

namespace me.Maze
{
    /// <summary>
    /// 方向
    /// </summary>
    enum Direction
    {
        Up,
        Right,
        Down,
        Left,
    }

    abstract class Entity
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Direction Direction { get; set; }

        /// <summary>
        /// 向いている方向に進ことができるかを判断
        /// </summary>
        /// <param name="maze"></param>
        /// <returns>向いている方向に進ことができるならtrue、それ以外ならfalseを返す</returns>
        public bool CanMove(Maze maze)
        {
            int[,] content = maze.Content;
            int loc = content[X, Y];

            switch (this.Direction)
            {
                case Direction.Up:
                    if (loc == 1 || loc == 3 || loc == 5 || loc == 7 || loc == 9 || loc == 11 || loc == 13)
                        return false;
                    break;

                case Direction.Right:
                    if (loc == 2 || loc == 3 || loc == 6 || loc == 7 || loc == 10 || loc == 11 || loc == 14)
                        return false;
                    break;

                case Direction.Down:
                    if (loc == 4 || loc == 5 || loc == 6 || loc == 7 || loc == 12 || loc == 13 || loc == 14)
                        return false;
                    break;

                case Direction.Left:
                    if (loc == 8 || loc == 9 || loc == 10 || loc == 11 || loc == 12 || loc == 13 || loc == 14)
                        return false;
                    break;

                default:
                    Console.WriteLine("CanMove() has error.");
                    return false;
            }

            return true;
        }

        /// <summary>
        /// キャラクターを進める
        /// </summary>
        /// <param name="maze"></param>
        public void Move(Maze maze)
        {
            if (CanMove(maze))
                switch (this.Direction)
                {
                    case Direction.Up:
                        Y -= 1;
                        break;

                    case Direction.Right:
                        X += 1;
                        break;

                    case Direction.Down:
                        Y += 1;
                        break;

                    case Direction.Left:
                        X -= 1;
                        break;

                    default:
                        Console.WriteLine("Move() has error.");
                        break;
                }
            else
                Console.WriteLine("その方向には進行できません。");
        }
    }
}
