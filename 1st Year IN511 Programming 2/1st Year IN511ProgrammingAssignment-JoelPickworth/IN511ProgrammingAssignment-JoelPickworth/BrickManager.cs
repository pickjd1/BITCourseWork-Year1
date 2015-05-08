using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace IN511ProgrammingAssignment_JoelPickworth
{
    public class BrickManager
    {        
        private const int NCOL = 6;
        private const int NROWS = 4;
        private Brick[,] bricks;
        public Brick[,] Bricks;


        public BrickManager(Graphics graphics)
        {

            bricks = new Brick[NCOL, NROWS];
            for (int i = 0; i < NCOL; i++)
            {
                for (int j = 0; j < NROWS; j++)
                {
                    bricks[i, j] = new Brick(new Point((i * 105), (j * 35)), new Point(90, 30), graphics, Color.LimeGreen);
                }
            }
        }

        public void Draw()
        {
            for (int i = 0; i < NCOL; i++)
            {
                for (int j = 0; j < NROWS; j++)
                {
                    bricks[i, j].Draw();
                }
            }
        }

       public void Collision(Ball ball, Brick brick)
        {

            for (int i = 0; i < NCOL; i++)
                {
                    for (int j = 0; j < NROWS; j++)
                        {
                            if (bricks[i, j].Visible == true)
                                {
                                    if (((ball.Position.Y <= (bricks[i,j].Position.Y + bricks[i, j].Size.Y)) && ((ball.Position.Y + ball.Diameter) > (bricks[i, j].Position.Y))))
                                        {
                                            if (((ball.Position.X + ball.Diameter) > (bricks[i, j].Position.X)) && ((ball.Position.X) < (bricks[i, j].Position.X) + (bricks[i, j].Size.X)))
                                                {
                                                    ball.Velocity = new Point((ball.Velocity.X), (ball.Velocity.Y * -1));
                                                    bricks[i, j].Visible = false;
                                                    
                                                    /*for (int i = 0; i < count; i++)
                                                    {
                                                        listBox1.Items.Add(100 + i);
                                                    }*/
                                                }
                                        }
                                }
                        }
                }
        }
 
    }
}
