using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Laba_one.Shapes.Helpers
{
    internal class CirclePoint
    {
        public int X;
        public int Y;
        public int MaxX;
        public int MinX;
        public int MaxY;
        public int MinY;

        public CirclePoint(int x, int y, int pictureBoxHeight, int pictureBoxWidth)
        {
            X = x;
            Y = y;
            MaxX = pictureBoxWidth;
            MinX = 0;
            MaxY = pictureBoxHeight;
            MinY = 0;
        }

    }
}
