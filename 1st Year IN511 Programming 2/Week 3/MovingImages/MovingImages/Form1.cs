﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MovingImages
{
    public partial class imageMoving : Form
    {
        public imageMoving()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Top = pictureBox1.Top + 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Left = pictureBox2.Left + 10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            button3.Text = "Stop";
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox3.Left = pictureBox3.Left - 10;
            pictureBox3.Top = pictureBox3.Top + 10;
        }
    }
}
