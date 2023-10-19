using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_number_one.Shapes
{
    internal class Line
    {
        private int X;
        private int Y;
        private Bitmap Bitmap;
        private Color Color;

        public Line(int x, int y, Bitmap bitmap, Color color)
        {
            X = x;
            Y = y;
            Bitmap = bitmap;
            Color = color;
        }

        public void SetColor(Color color)
        {
            Color = color;
        }
    }
}
