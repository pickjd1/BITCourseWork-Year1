using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GraphicsForm
{
    public partial class Form1 : Form
    {
        private Graphics graphics;

        public Form1()
        {
            InitializeComponent();
            graphics = CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            graphics.DrawLine(Pens.Red, new Point(10,10), new Point (80,80));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            graphics.DrawLine(Pens.Red, new Point(10, 80), new Point(80, 10));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            graphics.FillRectangle(Brushes.Red, new Rectangle(100, 20, 100, 50));
            graphics.DrawRectangle(Pens.Blue, new Rectangle(100, 20, 100, 50));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            graphics.FillEllipse(Brushes.Black, new Rectangle(170, 290, 400, 200));
            graphics.FillEllipse(Brushes.Purple, new Rectangle(180, 300, 400, 200));
            graphics.DrawEllipse(Pens.Green, new Rectangle(180, 300, 400, 200));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Font font = new Font("Old English Text MT", 35, FontStyle.Bold);
            graphics.DrawString("Hi There!!", font, Brushes.SkyBlue, 210,360);
        }
    }
}
