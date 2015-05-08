using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private GameManager gameManager;
        private Point bounds;

        //constructor
        public Form1()
        {
            InitializeComponent();
            Width = 800;
            Height = 600;
            Top = 20;
            Left = 20;

            gameManager = new GameManager(graphics);
            bounds = new Point(Width, Height);

            graphics = CreateGraphics();
            DoubleBuffered = true;
            gameManager = new GameManager(graphics);
            timer1.Enabled = true;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
            //graphics.FillRectangle(Brushes.Black, 0, 0, Width, Height);
            gameManager.Play();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            gameManager.MoveMotherShip(e.Location.X);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            gameManager.FireMissile(e.Location.X);
        }

    }
}
