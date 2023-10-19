using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Laba_num_one.My_Classes
{
    internal class Circle
    {
        private int X;
        private int Y;
        private int Radius;
        private Bitmap Bitmap;
        private Color Color;

        public Circle(Bitmap bitmap, Color color, int x, int y, int radius)
        {
            Bitmap = bitmap;
            Color = color;
            Radius = radius;
            X = x;
            Y = y;
        }

        public void SetColor(Color color)
        {
            Color = color;
        }
    }
}
