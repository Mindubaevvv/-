using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_number_one.Shapes
{
    internal class Line
    {
        private int X;
        private int Y;
        private Bitmap Bitmap;
        private Color Color;

        public Line(int x, int y, Bitmap bitmap, Color color) : this(x, y, color)
        {
            Bitmap = bitmap;
        }
        public Line(int x, int y, Color color)
        {
            X = x;
            Y = y;
            Color = color;
        }
        public Line(string x, string y)
        {
            X = Convert.ToInt32(x);
            Y = Convert.ToInt32(y);             
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
