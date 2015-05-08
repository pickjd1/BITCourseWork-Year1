using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NoughtsAndCrosses
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private GameBoard gameBoard;
    
        public Form1()
        {
            InitializeComponent();
            panel1.Width = 350;
            panel1.Height = 350;

            graphics = panel1.CreateGraphics();
            gameBoard = new GameBoard(graphics);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameBoard.SetupNewGame();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            gameBoard.PlayThisSquare(e.Location);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            gameBoard.SetupNewGame();
        }
    }
}
