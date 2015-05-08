using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProgrammingClass1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.visible = false;
            button1.Text = "Wrong Button";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "Wrong Button";
        }
    }
}
