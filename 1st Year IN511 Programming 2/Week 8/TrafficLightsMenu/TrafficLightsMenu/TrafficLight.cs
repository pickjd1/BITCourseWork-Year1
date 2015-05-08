using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace TrafficLightsMenu
{
    public class TrafficLight
    {
        private Color color1;
        public Color Color1
        {
            get { return color1; }
            set { color1 = value; }
        }

        private Color color2;
        public Color Color2
        {
            get { return color2; }
            set { color2 = value; }
        }

        private Color color3;
        public Color Color3
        {
            get { return color3; }
            set { color3 = value; }
        }

        private int sleepInterval;
        public int SleepInterval
        {
            get { return sleepInterval; }
            set { sleepInterval = value; }
        }

        private PictureBox pictureBox1;
        public PictureBox PictureBox1
        {
            get { return pictureBox1; }
            set { pictureBox1 = value; }
        }

        private PictureBox pictureBox2;
        public PictureBox PictureBox2
        {
            get { return pictureBox2; }
            set { pictureBox2 = value; }
        }

        private PictureBox pictureBox3;
        public PictureBox PictureBox3
        {
            get { return pictureBox3; }
            set { pictureBox3 = value; }
        }

        public TrafficLight(Color color1, Color color2, Color color3, PictureBox pictureBox1, PictureBox pictureBox2, PictureBox pictureBox3)
        {
            this.color1 = color1;
            this.color2 = color2;
            this.color3 = color3;
            this.pictureBox1 = pictureBox1;
            this.pictureBox2 = pictureBox2;
            this.pictureBox3 = pictureBox3;
            sleepInterval = 1000;
        }

        public void Flash()
        {
            pictureBox3.BackColor = color3;
            Application.DoEvents();
            Thread.Sleep(sleepInterval);
            pictureBox3.BackColor = Color.Black;

            pictureBox2.BackColor = color2;
            Application.DoEvents();
            Thread.Sleep(sleepInterval);
            pictureBox2.BackColor = Color.Black;

            pictureBox1.BackColor = color1;
            Application.DoEvents();
            Thread.Sleep(sleepInterval);
            pictureBox1.BackColor = Color.Black;
        }
    }
}
