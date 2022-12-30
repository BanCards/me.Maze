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

            if (this.Direction == Direction.Up)
                if (loc == 1 || loc == 3 || loc == 5 || loc == 7 || loc == 9 || loc == 11 || loc == 13)
                    return false;

            if (this.Direction == Direction.Right)
                if (loc == 2 || loc == 3 || loc == 6 || loc == 7 || loc == 10 || loc == 11 || loc == 14)
                    return false;

            if (this.Direction == Direction.Down)
                if (loc == 4 || loc == 5 || loc == 6 || loc == 7 || loc == 12 || loc == 13 || loc == 14)
                    return false;

            if (this.Direction == Direction.Left)
                if (loc == 8 || loc == 9 || loc == 10 || loc == 11 || loc == 12 || loc == 13 || loc == 14)
                    return false;

            return true;
        }

        /// <summary>
        /// キャラクターを進める
        /// </summary>
        /// <param name="maze"></param>
        public void Move(Maze maze)
        {
            if (CanMove(maze) == true)
            {
                if (this.Direction == Direction.Up)
                    Y -= 1;

                if (this.Direction == Direction.Right)
                    X += 1;

                if (this.Direction == Direction.Down)
                    Y += 1;

                if (this.Direction == Direction.Left)
                    X -= 1;
            }
        }
    }
}
