using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpaceInvaders;
using System.Drawing;
using System.Windows.Forms;

namespace spaceInvaders.cs
{
    public class GameManager
    {
        private const int STARTMOTHERSHIPX = 400;
        private const int STARTMOTHERSHIPY = 450;
        private const int CHANGEDIRECTION = -1;
        private const int VERTICALDROP = 20;
        

        private Missile[] missiles;
        private EnemyShip enemyShip;
        private EnemyFleet enemyFleet;
        private MotherShip motherShip;
        

        public GameManager(Graphics graphics, Point position, Point bounds)
        {
            motherShip = new MotherShip(new Point(STARTMOTHERSHIPX, STARTMOTHERSHIPY), true, "MF.jpg", graphics, bounds);
            enemyFleet = new EnemyFleet(graphics, position, bounds);

            missiles = new Missile[15];
           
            //missile array
            for (int i = 0; i < missiles.Length; i++)
            {
                missiles[i] = new Missile(new Point(100, 400), false, "laser.png", graphics, bounds);
            }
 
        }

        public void Play(Point position, Point bounds, int speed, int newY, Timer timer1)
        {
            motherShip.Draw();
            enemyFleet.Draw();
            enemyFleet.Move();
            enemyFleet.MoveBombs();
            enemyFleet.DrawBombs();
            MoveMissiles();
            DrawMissiles();
            enemyFleet.MoveBombs();
            enemyFleet.DrawBombs();
            enemyFleet.DropBombs();
            enemyFleet.BombLifeSpan(bounds);
            enemyFleet.MotherShipCollision(motherShip);

        }

        public void MoveMotherShip(int newX)
        {
            motherShip.Move(newX);
        }

        //draws missiles
        public void DrawMissiles()
        {
            for (int i = 0; i < missiles.Length; i++)
            {
                missiles[i].Draw();
            }
        }

        //fires missiles
        public void FireMissile(int newX)
        {
            for (int i = 0; i < missiles.Length; i++)
            {
                if (missiles[i].Alive == false)
                {
                    missiles[i].Alive = true;
                    missiles[i].Position = new Point(newX+28, STARTMOTHERSHIPY);
                    break;
                }
            }
            MissileLifeSpan();
        }
        // moves missiles
        public void MoveMissiles()
        {
            for (int i = 0; i < missiles.Length; i++)
            {
                missiles[i].Move();
            }
        }

        public void MissileLifeSpan()
        {
            for (int i = 0; i < missiles.Length; i++)
            {
                if (missiles[i].Position.Y < 0)
                {
                    missiles[i].Alive = false;
                }
            }
        }


    }

}