using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace spaceInvaders.cs
{
    abstract class Ship
    {
        private Point position;
        private Bitmap image;
        private Boolean alive;
        private String filename;
        private Graphics graphics;

        public Point Position
        {
            get { return position; }
            set { position = value; }
        }
        

       public Bitmap Image
        {
            get { return image; }
            set { image = value; }
        }
        

        public Boolean Alive
        {
            get { return alive; }
            set { alive = value; }
        }
        
        //private Timer timer;

        public Ship(Boolean alive, Bitmap image, Point position, String filename, Graphics graphics)
        {
            this.image = new Bitmap(filename);
            this.position = position;
            this.alive = true;
            this.filename = filename;
            this.graphics = graphics;
            
        }

        public void Collision()
        {
            
        }

        //public void DisplayImage()
        //{
        //    //DISPLAYS THE SQUARE IMAGE AND WHERE
        //    graphics.DrawImage(image, Bounds.Left, Bounds.Top);
        //}

        public void Draw()
        {
            graphics.DrawImage(image, position);
            //image = Image.FromFile();
            //DisplayImage();
        }

        public abstract void Move();
    }
}
