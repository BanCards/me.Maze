using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace me.Maze
{
    class Maze
    {
        public int[,] Content { get; }
        public int PlayerStartPosX { get; }
        public int PlayerStartPosY { get; }
        public int GoalPosX { get; }
        public int GoalPosY { get; }
        public int EnemyStartPosX { get; }
        public int EnemyStartPosY { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="content"></param>
        /// <param name="playerStartPosX"></param>
        /// <param name="playerStartPosY"></param>
        /// <param name="goalPosX"></param>
        /// <param name="goalPosY"></param>
        /// <param name="enemyStartPosX"></param>
        /// <param name="enemyStartPosY"></param>
        public Maze(int[,] content, int playerStartPosX, int playerStartPosY, int goalPosX, int goalPosY, int enemyStartPosX, int enemyStartPosY)
        {
            this.Content = content;
            this.PlayerStartPosX = playerStartPosX;
            this.PlayerStartPosY = playerStartPosY;
            this.GoalPosX = goalPosX;
            this.GoalPosY = goalPosY;
            this.EnemyStartPosX = enemyStartPosX;
            this.EnemyStartPosY = enemyStartPosY;
        }
    }
}