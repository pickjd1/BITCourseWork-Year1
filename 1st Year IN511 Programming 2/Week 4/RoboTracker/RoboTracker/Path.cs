using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace RoboTracker
{
    public class Path
    {
        const int MAXPOINT = 1000;
        private Point[] points;
        private int path;
        private bool isDrawing;
        private int pathCount = 0;

        public Path()
        {
            throw new System.NotImplementedException();
        }

        public void StartPath(Point point)
        {
            pathCount = 0;
            points[pathCount] = point;
            isDrawing = true;
        }

        public void DrawPath(Graphics graphics, Pen pen)
        {
            throw new System.NotImplementedException();
        }

        public void StopPath()
        {
            throw new System.NotImplementedException();
        }
    }
}
