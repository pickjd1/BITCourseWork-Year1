using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace NoughtsAndCrosses
{
    public class GameSquare
    {
        private const String SOLID = "solid.bmp";
        private const String X = "X.bmp";
        private const String O = "O.bmp";

        private Image image;
        private Rectangle bounds;
        private Graphics graphics;
        private bool filled;

        public Image Image
        {
            get { return image; }
            set { image = value; }
        }
        public Rectangle Bounds
        {
            get { return bounds; }
            set { bounds = value; }
        }
        public Graphics Graphics
        {
            get { return graphics; }
            set { graphics = value; }
        }
        public bool Filled
        {
            get { return filled; }
            set { filled = value; }
        }

        public GameSquare(Graphics graphics, int left, int top, int width, int height)
        {
            this.graphics = graphics;
            bounds = new Rectangle(left, top, width, height);
            filled = false;
        }

        public void SetUp()
        {
            image = Image.FromFile(SOLID);
            DisplayImage();
            filled = false;
        }

        public void DisplayImage()
        {
            graphics.DrawImage(image, bounds.Left, bounds.Top);
        }

        public bool FindActiveSquare(Point point)
        {
            bool foundSquare = false;
            if (bounds.Contains(point))
            {
                foundSquare = true;
            }
            return foundSquare;
        }

        public void Play(bool playerX)
        {
            if (filled == false)
            {
                if (playerX)
                {
                    image = Image.FromFile(X);
                }
                else
                {
                    image = Image.FromFile(O);
                }
                DisplayImage();
                filled = true;
            }
        }
    }
}
