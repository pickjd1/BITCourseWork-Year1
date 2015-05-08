using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RoboTracker
{
    public partial class Form1 : Form
    {
        private Robot robot;
        private Path path;
        private Graphics graphics;
        private Pen pen;
    
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Point[] path = new Point[1000];
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
