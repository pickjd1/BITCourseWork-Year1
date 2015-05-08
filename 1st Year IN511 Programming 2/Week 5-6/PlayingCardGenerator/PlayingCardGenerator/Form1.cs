using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PlayingCardGenerator
{
    public partial class Form1 : Form
    {
        private Deck deck;
        private Random random;
    
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            deck = new Deck(random);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Text = deck.SelectACard().ToLower();
        }
    }
}
