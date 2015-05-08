using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BottlesOfBeer
{
    public partial class BottlesOfBeer : Form
    {
        public BottlesOfBeer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int count=Convert.ToInt32(textBox1.Text);
            if (count < 100)
            {
                for (int i = 0; i < count; i++)
                {
                    listBox1.Items.Add((99 - i) + " bottles of beer on the wall");
                }
            }
            else
            {
                MessageBox.Show("Please choose a number between 0 and 99");
            }
        }
    }
}
