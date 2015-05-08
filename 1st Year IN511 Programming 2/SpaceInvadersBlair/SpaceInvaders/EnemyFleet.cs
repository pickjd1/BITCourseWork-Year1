using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace SpaceInvaders
{
    class EnemyFleet
    {
        private const int VERTICALDROP = 20;
        private const int CHANGEDIRECTION = -1;
        //constant and fields
        private const int NCOL = 10;
        private const int NROWS = 4;
        private Random rand;

       
        private Point position;

        
        
        private EnemyShip[,] enemyShips;
        
        private Bomb[] bombs;



        //constructor
        public EnemyFleet(Graphics graphics, Point position, Point bounds)
        {
            bombs = new Bomb[10];
            rand = new Random();

            enemyShips = new EnemyShip[NCOL, NROWS];

            for (int i = 0; i < NCOL; i++)
            {
                for (int j = 0; j < NROWS; j++)
                {
                    enemyShips[i, j] = new EnemyShip(new Point((i * 50), (j * 50)), true, "spaceinvaderfinger.jpg", graphics, bounds );
                }

            }


            //bomb array
            for (int i = 0; i < bombs.Length; i++)
            {
                bombs[i] = new Bomb(new Point(400, 0), false, "bomb.bmp", graphics, bounds);
            }

        }

        //draws enenmy fleet
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

        //moves enemy fleet
        public void Move()
        {
            for (int i = 0; i < NCOL; i++)
            {
                for (int j = 0; j < NROWS; j++)
                {
                    enemyShips[i, j].Move();
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

        //bomb drops
        public void DropBombs()
        {
            int dropabomb = rand.Next(4);

            for (int i = 0; i < bombs.Length; i++)
            {

                if(dropabomb==3)
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

        public void BombLifeSpan(Point bounds)
        {
            
            for (int i = 0; i < bombs.Length; i++)
            {
                if (bombs[i].Position.Y > bounds.Y)
                {
                    bombs[i].Alive = false;
                }
            }
        }

        public void MotherShipCollision(MotherShip motherShip)
        {
            for (int i = 0; i < bombs.Length; i++)
			{
			 
			
            if (((motherShip.Position.Y) > (bombs[i].Position.Y)) || ((motherShip.Position.Y) > (bombs[i].Position.Y)))
            {
                if (((motherShip.Position.X) > (bombs[i].Position.X)) && ((motherShip.Position.X) < (bombs[i].Position.X)))
                {
                    
                   MessageBox.Show("Game Over!! Use menu to select option");
                }
            }
        }
        }

        public void MissileCollision()
              {
            for (int i = 0; i < NCOL; i++)
            {
                for (int j = 0; j < NROWS; j++)
                {
                    if (enemyShips[i, j].Alive == true)
                    {
                        if (((ball.Position.Y <= (bricks[i, j].Position.Y + bricks[i, j].Height+21)) && ((ball.Position.Y + ball.Diameter) > (bricks[i, j].Position.Y))))
                        {
                            if (((ball.Position.X + ball.Diameter) > (bricks[i, j].Position.X)) && ((ball.Position.X) < (bricks[i, j].Position.X) + (bricks[i, j].Width)))
                            {
                                ball.Velocity = new Point((ball.Velocity.X), (ball.Velocity.Y * -1));
                                bricks[i, j].Visible = false;
                                score +=10; // + score by 10 for each brick turned visible=false
                                label1.Text = "Score: " + Convert.ToString(score); //writes score in label
                            }
                        }
                    }
                }
            }
        }
    }
        
        //Properties
        public Point Position
        {
            get { return position; }
            set { position = value; }
        }


    }
}
