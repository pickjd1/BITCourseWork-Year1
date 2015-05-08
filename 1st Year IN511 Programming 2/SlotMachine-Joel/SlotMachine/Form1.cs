/*
 Title:        
 Author:       
 Date:  
 Language:
 Platform:
 Purpose:
 Description:  
 Additional Features:
 Known Bugs:
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SlotMachine
{
    public partial class Form1 : Form
    {
        //constants
        const int NSPINS = 20;
        const int NIMAGES = 3;

        //fields
        private Random random; 
        private int winnings;
        private String[] images;

        private Spinner spinner1;
        private Spinner spinner2;
        private Spinner spinner3;

        //properties
       

        //constructor
        public Form1()
        {
            InitializeComponent();

            random = new Random();

            images = new String[NIMAGES];

            images[0] = "Images/coyote.bmp";
            images[1] = "Images/tree.bmp";
            images[2] = "Images/sheep.bmp";
           
            spinner1 = new Spinner(random, NIMAGES, images, NSPINS, pictureBox1);
            spinner2 = new Spinner(random, NIMAGES, images, NSPINS, pictureBox2);
            spinner3 = new Spinner(random, NIMAGES, images, NSPINS, pictureBox3);

            this.winnings = 100;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //write the intial value of winnings to the textbox
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //the Button 1_Click event should only be used to call methods, there should be no processing in this event handler
            RunSlotMachine();
        }

        private void RunSlotMachine()
        {
            // charge user $10

            //update information in textboxes
            

            //spin each box in turn
          

            //check to see if the three boxes match
        

            //check to see if user has run out of money
           
        }
    }
}



