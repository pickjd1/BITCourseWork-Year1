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
        private Ball ball;
        private Paddle paddle;
    
        public Form1()
        {
            InitializeComponent();
            graphics = CreateGraphics();
        }

        public void Run()
        {
            Refresh();
        }

        public void paddleMove()
        {
            throw new System.NotImplementedException();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
