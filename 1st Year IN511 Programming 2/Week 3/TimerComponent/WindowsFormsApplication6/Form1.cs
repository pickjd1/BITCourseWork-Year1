using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (Convert.ToInt16(textBox1.Text) + 1).ToString();
            timer1.Interval += 100;
        }

        //Need to look at changing text value of button:
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Stop";
            //Next line is a switch for any boolean property using the nod - !:
            timer1.Enabled = !timer1.Enabled;
            button1.Text = "Start";
        }
    }
}
