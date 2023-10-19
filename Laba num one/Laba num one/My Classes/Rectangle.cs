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
        private int _x;
        private int _y;
        private int _horizontal;
        private int _vertical;
        private Bitmap _bitmap;
        private Color _color;

        public Rectangle(int x, int y, int horizontal, int vertical, Bitmap bitmap, Color color)
        {
            _x = x;
            _y = y;
            _horizontal = horizontal;
            _vertical = vertical;
            _bitmap = bitmap;
            _color = color;
        }

        public void SetColor(Color color)
        {
            _color = color;
        }
    }
}
