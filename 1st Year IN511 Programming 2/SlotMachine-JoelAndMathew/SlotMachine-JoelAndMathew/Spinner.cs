using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace SlotMachine_JoelAndMathew
{
    public class Spinner
    {
        private int nImages;
        private Image[] images;
        private PictureBox pictureBox;
        private int NMILLISECONDS = 100;

        public Spinner (int nImages, String[] images, PictureBox pictureBox )
        {
            Random rand = new Random(2);
            this.nImages = nImages;
            this.images = new Image[nImages];

            for (int i = 0; i < images.Length; i++)
            {
                this.images[i] = Image.FromFile(images[i]);
            }
            this.pictureBox = pictureBox;
        }

        public void NImages()
        {
        }

        public void Images()
        {
        }

        public void PictureBox()
        {
        }
        public void Run()
        {
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                pictureBox.Image = images[rand.Next(2)];

                Application.DoEvents();
                Thread.Sleep(NMILLISECONDS);
            }
        }
    }
}
