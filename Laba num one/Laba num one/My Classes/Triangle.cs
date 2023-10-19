using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Laba_num_one.My_Classes
{
    internal class Triangle
    {
        private int _x;
        private int _y;
        private int _left;
        private int _right;
        private int _leftHeight;
        private int _rightHeight;
        private Bitmap _bitmap;
        private Color _color;

        public Triangle(int x, int y, int left, int right, int leftHeight, int rightHeight, Bitmap bitmap, Color color)
        {
            _x = x;
            _y = y;
            _left = left;
            _right = right;
            _leftHeight = leftHeight;
            _rightHeight = rightHeight;
            _bitmap = bitmap;
            _color = color;
        }

        public void SetColor(Color color) 
        { 
            _color = color; 
        }
    }
}
