/* The Animator class
 * This class is used to hold the picture data for running the sprite animation.
 * The methods include the running of the animation itself and the run command.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Week2Lab3Sprite
{
    public class Animator
    {
        private Image[] images;

        // Fields hold the data for the class:
        private int nImages;
        private int NMILLISECONDS = 100;
        private PictureBox pictureBox;

        //Sets the sleep time between images

/* The constructor
 * This is used to initiliase every field value. (Puts the data into the fields).
*/

        public Animator(int nImages, String[] images, PictureBox pictureBox)
        {
            this.nImages = nImages;
            this.images = new Image[nImages];

            for (int i = 0; i < images.Length; i++)
            {
                this.images[i] = Image.FromFile(images[i]);
            }

            this.pictureBox = pictureBox;
        }

        public void Run()
        {
            for (int i = 0; i < images.Length; i++)
            {
                pictureBox.Image = images[i];

                Application.DoEvents();
                Thread.Sleep(NMILLISECONDS);
            }
        }
    }
}
