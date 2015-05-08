using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SlotMachine_JoelAndMathew
{
    public partial class Form1 : Form
    {
        public const int NIMAGES = 3;
        private String[] images = new String[NIMAGES];
        
        public String[] Images
        {
            get { return images; }
            set { images = value; }
        }
        private Spinner spinner;

        public Spinner Spinner 
        {
            get { return spinner; }
            set { spinner = value; }
        }
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 20; i++)
            {
              this.images[i] = Image.FromFile(images[2]);
            }
            spinner = new Spinner(NIMAGES, images, pictureBox1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            spinner.Run();
        }
    }
}
