using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public class EnemyFleet
    {
        private const int NCOL = 5;
        private const int NROWS = 4;
        private const int CHANGEDIRECTION = -1;
        private const int VERTICALDROP = 30;

        private Random rand;
        private EnemyShip[,] enemyShips;
        private Bomb[] bombs;

        //constructor
        public EnemyFleet(Graphics graphics)
        {
            bombs = new Bomb[10];
            rand = new Random();

            enemyShips = new EnemyShip[NCOL, NROWS];
            for (int i = 0; i < NCOL; i++)
            {
                for (int j = 0; j < NROWS; j++)
                {
                    enemyShips[i, j] = new EnemyShip(new Point((i * 105), (j * 35)), true, "EnemyShip.bmp", graphics);
                }
            }

            for (int i = 0; i < bombs.Length; i++)
            {
                bombs[i] = new Bomb(new Point(400, 0), false, "bomb.bmp", graphics);
            }

        }

        public void Draw()
        {
            for (int i = 0; i < NCOL; i++)
            {
                for (int j = 0; j < NROWS; j++)
                {
                    enemyShips[i, j].Draw();
                }
            }
        }

        public void Move()
        {
            for (int i = 0; i < NCOL; i++)
            {
                for (int j = 0; j < NROWS; j++)
                {
                    enemyShips[i, j].MoveX();
                    enemyShips[i, j].MoveY();
                }
            }

        }

        public void MoveBombs()
        {

            for (int i = 0; i < bombs.Length; i++)
            {
                bombs[i].BombMove();
            }
        }


        public void DrawBombs()
        {
            for (int i = 0; i < bombs.Length; i++)
            {
                bombs[i].Draw();
            }
        }

        public void DropBombs()
        {
            int dropbomb = rand.Next(3);
            for (int i = 0; i < bombs.Length; i++)
            {
                
                if (dropbomb == 2)
                {
                    if (bombs[i].Alive == false)
                    {
                        bombs[i].Alive = true;
                        bombs[i].Position = new Point(enemyShips[i,0].Position.X, enemyShips[i,0].Position.Y);
                        break;
                    }
                }
            }
        }

        public void BombLifeSpan()
        {

            for (int i = 0; i < bombs.Length; i++)
            {
                if (bombs[i].Position.Y > 590)
                {
                    bombs[i].Alive = false;
                }
            }
        }

    }
}
