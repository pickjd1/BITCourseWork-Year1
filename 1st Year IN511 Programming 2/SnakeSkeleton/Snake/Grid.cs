﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SnakeGame
{
    public class Grid : DataGridView
    {
        //constants
        private const int NCELLS = 30;
        private const int CELLSIZE = 17;
        private const int SPACESIZE = 4;

        //fields
        private Bitmap blank;

        //constructor
        public Grid(String fileName)
            : base()
        {
            //initialise fields
            blank = new Bitmap(fileName);

            // set position of grid on the Form:
            Top = 0;
            Left = 0;

            // setup the columns to display images. We want to display images, so we set 30 columns worth of Image columns:
            for (int x = 0; x < NCELLS; x++)
            {
                Columns.Add(new DataGridViewImageColumn());
            }

            // then we can tell the grid the number of rows we want to display:
            RowCount = NCELLS;

            // set the properties of the grid(which is a DataGridView object):
            Height = NCELLS * CELLSIZE + SPACESIZE;
            Width = NCELLS * CELLSIZE + SPACESIZE;
            ScrollBars = ScrollBars.None;
            ColumnHeadersVisible = false;
            RowHeadersVisible = false;

            foreach (DataGridViewRow r in this.Rows)
                r.Height = CELLSIZE;

            foreach (DataGridViewColumn c in this.Columns)
                c.Width = CELLSIZE;

            // rows and columns should never resize themselves to fit cell contents:
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            // prevent user from resizing rows or columns:
            AllowUserToResizeColumns = false;
            AllowUserToResizeRows = false;
        } 
        
        //properties
        public Bitmap Blank
        {
            get { return blank; }
            set { blank = value; }
        }      

        //methods
        public void Draw()
        {
            for (int i = 0; i < NCELLS; i++)
            {
                for (int j = 0; j < NCELLS; j++)
                {
                    Rows[i].Cells[j].Value = blank;
                }
            }
        }                       
    }
}
