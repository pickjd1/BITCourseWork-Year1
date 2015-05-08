using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RadioButtons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                pictureBox1.Load("13S.jpg");
            }
            if (radioButton2.Checked)
            {
                pictureBox1.Load("12S.jpg");
            }
            if (radioButton3.Checked)
            {
                pictureBox1.Load("11S.jpg");
            }
            if (radioButton4.Checked)
            {
                pictureBox2.Load("1D.jpg");
            }
            if (radioButton5.Checked)
            {
                pictureBox2.Load("5H.jpg");
            }
            if (radioButton6.Checked)
            {
                pictureBox2.Load("10C.jpg");
            }

        }

    }
}
