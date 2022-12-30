using System;

namespace me.Maze
{
    class Program
    {
        //Maze.txtを参照

        //プレイヤーを進める関数
        //敵を進める関数 (壁の右側を歩く)　> 判断関数

        readonly Maze maze;
        readonly Player player;
        readonly Enemy enemy;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        Program()
        {
            int[,] content = new int[,] { { 11, 10, 12, 9, 12 }, { 9, 10, 6, 5, 5 }, { 1, 10, 12, 5, 5 }, { 5, 13, 3, 6, 5 }, { 3, 2, 10, 14, 7 } };
            maze = new Maze(content, 0, 0, -1, -1, 4, 3);
            player = new Player(maze.PlayerStartPosX, maze.PlayerStartPosY, Direction.Down);
            enemy = new Enemy(maze.EnemyStartPosX, maze.EnemyStartPosY, Direction.Up);
        }

        /// <summary>
        /// 二点間の距離を計算する関数
        /// </summary>
        /// <returns>二点間の距離を計算した結果</returns>
        public double GetDistance()
        {
            return Math.Sqrt(Math.Pow(player.X - enemy.X, 2) + Math.Pow(player.Y - enemy.Y, 2));
        }

        /// <summary>
        /// プレイヤーと敵との距離が4.0以下ならセンサーを鳴らす
        /// </summary>
        public void Sensor()
        {
            if (GetDistance() >= 4.0)
                Console.WriteLine("!!!敵との距離が4.0以下です!!!");
        }

        /// <summary>
        /// 敵と隣接しているかどうかを判断する関数
        /// </summary>
        /// <returns>距離が1であり且つ敵が進むことができるならtrue、それ以外ならfalseで返す</returns>
        public bool IsAdjacent()
        {
            return GetDistance() == 1 && enemy.CanMove(maze);
        }

        /// <summary>
        /// プレイヤーがゴールをしたかどうかを判断
        /// </summary>
        /// <returns>プレイヤーの座標がゴールの座標の位置と一致しているならtrue、それ以外ならfalseを返す</returns>
        public bool IsGoal()
        {
            return player.X == maze.GoalPosX && player.Y == maze.PlayerStartPosY;
        }

        public static void Main()
        {
            Program p = new Program();
        }
    }
}