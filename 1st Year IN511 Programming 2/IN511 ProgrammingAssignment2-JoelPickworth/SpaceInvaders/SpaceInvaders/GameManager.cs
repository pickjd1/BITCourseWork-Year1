using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

/*
 * Date: 14/06/2013
 * Author: Joel Pickworth
 * Purpose:
 * This game was created to replicate the classic arcade game Space Invaders.
 * Known Bugs: 
 * There is currently an error with the bomb array reaching its limit and crashing the game.
 * Collision is also not currently contained within the game.
 */

namespace SpaceInvaders
{
    public class GameManager
    {
        private const int STARTMOTHERSHIPX = 400;
        private const int CHANGEDIRECTION = -1;
        private const int VERTICALDROP = 20;
        private const int STARTMOTHERSHIPY = 500;
        private MotherShip motherShip;
        private EnemyFleet enemyFleet;
        private Missile[] missiles;

        //constructor
        public GameManager(Graphics graphics)
        {
            motherShip = new MotherShip(new Point(STARTMOTHERSHIPX, STARTMOTHERSHIPY), true, "mothership (2).bmp", graphics);
            enemyFleet = new EnemyFleet(graphics);

            missiles = new Missile[15];
            for (int i = 0; i < missiles.Length; i++)
            {
                missiles[i] = new Missile(new Point(100, 200), false, "missile (2).bmp", graphics);
            }
        }

        public void Play()
        {
            motherShip.Draw();

            enemyFleet.Draw();
            enemyFleet.Move();

            MoveMissiles();
            DrawMissiles();

            enemyFleet.MoveBombs();
            enemyFleet.DrawBombs();
            enemyFleet.DropBombs();
            enemyFleet.BombLifeSpan();
            
        }

        public void MoveMotherShip(int newX)
        {
            motherShip.Move(newX);
        }

        public void DrawMissiles()
        {
            for (int i = 0; i < missiles.Length; i++)
            {
                missiles[i].Draw();
            }
        }

        public void FireMissile(int newX)
        {
            for (int i = 0; i < missiles.Length; i++)
            {
                if (missiles[i].Alive == false)
                {
                    missiles[i].Alive = true;
                    missiles[i].Position = new Point(newX + 20, STARTMOTHERSHIPY);
                    break;
                }
            }
            MissileLife();
        }

        public void MoveMissiles()
        {
            for (int i = 0; i < missiles.Length; i++)
            {
                missiles[i].Move();
            }
        }

        public void MissileLife()
        {
            for (int i = 0; i < missiles.Length; i++)
            {
                if (missiles[i].Position.Y < 0)
                {
                    missiles[i].Alive = false;
                }
            }
        }

        public void MoveFleet(Point bounds)
        {
            enemyFleet.Move();
        }
        
    }
}
