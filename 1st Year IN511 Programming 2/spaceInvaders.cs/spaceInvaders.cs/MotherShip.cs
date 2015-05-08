using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace spaceInvaders.cs
{
    public class MotherShip:Ship
    {
        private const String MOTHERSHIP = "mothership (2).bmp";
        private Image image;

        public MotherShip(bool alive, Bitmap image, Point position, String filename, Graphics graphics)
            :base (alive, image, position, filename, graphics)
        {
            
        }


        public Image Image
        {
            get { return image; }
            set { image = value; }
        }

        public void Display()
        {
            //SET UP SQUARE IMAGE
            image = Image.FromFile(MOTHERSHIP);
            //DisplayImage();
       
        }

        public void Fire()
        {
           
        }

        public override void Move()
        {
           
        }
    }
}
