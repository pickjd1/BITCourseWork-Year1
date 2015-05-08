/*
 * Program Name: Sprite Animation
 * Program File Name:  Week2Lab3Sprite
 * Author:  Joel Pickworth
 * Date:  27/02/2013
 * Language:  C#
 * Platform:  Microsoft Visual Studio 2010
 * Purpose:  To build a sprite animation application, intorducing classes.
 * Description:
 * Known Bugs:
 * Additional Features:
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Week2Lab3Sprite
{

    public partial class Form1 : Form
    {
        /*
         * CONSTANT: always in capitals
         * the number of images is defined at the beginning of the program
         * so that if you want to change the number of images later, you can
        */
        public const int NIMAGES = 10;
        private String[] images = new String[NIMAGES];

        public String[] Images
        {
            get { return images; }
            set { images = value; }
        }
        private Animator animator;

        public Animator Animator
        {
            get { return animator; }
            set { animator = value; }
        }
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < NIMAGES; i++)
            {
                images[i] = "Images/T" + i.ToString() + ".bmp";
            }
            animator = new Animator(NIMAGES, images, pictureBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            animator.Run();
        }
    }
}
