using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using spaceInvaders.cs;


namespace SpaceInvaders
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private Point position;
        private int newX;
        private EnemyFleet enemyFleet;
        private int speed;
        private int newY;
        private GameManager gameManager;
        private Point bounds;
        System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(Properties.Resources.blaster);

        public Form1()
        {
            InitializeComponent();
            Width = 800;
            Height = 600;
            Top = 20;
            Left = 20;
            bounds = new Point(Width, Height);
            //BackColor = Color.Black;
            DoubleBuffered = true;
            //Panel.BackColor = Color.Maroon;
            graphics = CreateGraphics();
            gameManager = new GameManager(graphics, position, bounds);
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            graphics.FillRectangle(Brushes.Black, 0, 0, Width, Height);
            gameManager.Play(position, bounds, speed, newY, timer1);
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            gameManager.FireMissile(e.Location.X);
            startSoundPlayer.Play();

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            gameManager.MoveMotherShip(e.Location.X);
        }

        //private void Form1_MouseClick(object sender, MouseEventArgs e)
        //{
            
        //}

        private void pauseGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void resumeGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button1.Visible = false;
        }


    }
}
