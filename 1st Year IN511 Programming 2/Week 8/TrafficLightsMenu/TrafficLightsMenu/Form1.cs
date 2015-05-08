using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrafficLightsMenu
{
    public partial class Form1 : Form
    {
        private TrafficLight trafficLight;
        private Random random;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            trafficLight = new TrafficLight(Color.Red, Color.Orange, Color.Green, pictureBox1, pictureBox2, pictureBox3);
        }

        private void traditionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trafficLight.Color1 = Color.Red;
            trafficLight.Color2 = Color.Orange;
            trafficLight.Color3 = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trafficLight.Flash();
        }

        private void mixedTraditionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trafficLight.Color1 = Color.Orange;
            trafficLight.Color2 = Color.Green;
            trafficLight.Color3 = Color.Red;
        }

        private void randomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trafficLight.Color1 = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            trafficLight.Color2 = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            trafficLight.Color3 = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

        }
    }
}
