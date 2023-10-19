using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_num_one.My_Classes
{
    internal class Line
    {
        private int _x;
        private int _y;
        private Bitmap _bitmap;
        private Color _color;

        public Line(int x, int y, Bitmap bitmap, Color color)
        {
            _x = x;
            _y = y;
            _bitmap = bitmap;
            _color = color;
        }

        public void SetColor(Color color)
        {
            _color = color;
        }
    }
}
