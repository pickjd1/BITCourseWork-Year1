using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CreatingPolygons
{
    public partial class Form1 : Form
    {
        private Random random;
        private Graphics graphics;
        private PolygonManager polygonManager;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            graphics = CreateGraphics();
            polygonManager = new PolygonManager(random, graphics);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
            String calculatedArea = polygonManager.CreatePolygon();
            label1.Text = "area = " + calculatedArea + "square units";
        }
    }
}
