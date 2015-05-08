using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IN511ProgrammingAssignment_JoelPickworth
{
    public partial class Form1 : Form
    {
        private BrickManager brickManager;
        private Graphics graphics;
        private Brick brick;
        private Ball ball;
        private Paddle paddle;
        private Point bounds;
    
        public Form1()
        {
            InitializeComponent();
            graphics = CreateGraphics();
            bounds = new Point(Width, Height);
            ball = new Ball(new Point(400, 200), new Point(20, 20), 15, graphics, bounds, Color.LimeGreen);
            paddle = new Paddle(new Point(20, 450), 90,30, graphics,Color.Silver, bounds);
            brickManager = new BrickManager(graphics);

            timer1.Enabled = true;
        }

        public void Run()
        {
            DoubleBuffered = true;
            Refresh();
            ball.Move();
            ball.Bounce();
            brickManager.Collision(ball,brick);
          
            ball.FallOffBottom(timer1);
            ball.HitTop();
            ball.HitPaddle(paddle);

            ball.Draw();
            brickManager.Draw();
            paddle.Draw();
            Application.DoEvents();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Run();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            paddle.Move(e.Location);
        }

    }
}
