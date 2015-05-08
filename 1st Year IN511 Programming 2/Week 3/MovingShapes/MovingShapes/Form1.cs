using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MovingShapes
{
    public partial class Form1 : Form
    {
        private Graphics graphics;

        public Form1()
        {
            InitializeComponent();

            graphics = CreateGraphics();

            graphics.FillRectangle(Brushes.Blue, new Rectangle(100, 100, 50, 50));
            graphics.DrawEllipse(Pens.Blue, new Rectangle(100, 100, 50, 50));

            graphics.FillRectangle(Brushes.Red, new Rectangle(200, 200, 50, 50));
            graphics.DrawEllipse(Pens.Red, new Rectangle(200, 200, 50, 50));

            graphics.FillRectangle(Brushes.Green, new Rectangle(300, 300, 50, 50));
            graphics.DrawEllipse(Pens.Green, new Rectangle(300, 300, 50, 50));

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
