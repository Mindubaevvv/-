using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Laba_num_one.My_Classes
{
    internal class Rectangle
    {
        private int X;
        private int Y;
        private int Horizontal;
        private int Vertical;
        private Bitmap Bitmap;
        private Color Color;

        public Rectangle(int x, int y, int horizontal, int vertical, Bitmap bitmap, Color color)
        {
            X = x;
            Y = y;
            Horizontal = horizontal;
            Vertical = vertical;
            Bitmap = bitmap;
            Color = color;
        }

        public void SetColor(Color color)
        {
            Color = color;
        }

        public void MoveTo(int x, int y)
        {
            X += X;
            Y += Y;
        }
    }
}
