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
        private int _x;
        private int _y;
        private int _radius;
        private Bitmap _bitmap;
        private Color _color;

        public Circle(Bitmap bitmap, Color color, int x, int y, int radius)
        {
            _bitmap = bitmap;
            _color = color;
            _radius = radius;
            _x = x;
            _y = y;
        }

        public void SetColor(Color color)
        {
            _color = color;
        }
    }
}
