/*
 Class comment
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace SlotMachine
{
    public class Spinner
    {
        //constants
        const int NMILLISECONDS = 100;

        //fields
        private Random random;
        private int nImages;
        private Image[] images;
        private int nFinalImage;
        private int nSpins;
        private PictureBox pictureBox;
    
        //properties

        //constructor
        public Spinner(Random random, int nImages, String[] images, int nSpins, PictureBox pictureBox)
        {
           
        }

        public void Spin()
        {
           
        }
    }
}



