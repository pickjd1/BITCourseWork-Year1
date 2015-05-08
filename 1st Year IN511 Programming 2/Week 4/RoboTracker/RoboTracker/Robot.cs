using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RoboTracker
{
    public class Robot
    {
        private PictureBox[] pictureBox;

        public PictureBox[] PictureBox
        {
            get { return pictureBox; }
            set { pictureBox = value; }
        }
    

        public Robot(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
        }

        public void EatPath(Path path)
        {
            for (int i = 0; i <= path.PathCount; i++)
            {
                pictureBox.Left = path.Points[i].X;
                pictureBox.Top = path.Points[i].Y;
            }
        }
    }
}
