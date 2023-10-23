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
        private int X;
        private int Y;
        private int Left;
        private int Right;
        private int LeftHeight;
        private int RightHeight;
        private Bitmap Bitmap;
        private Color Color;

        public Triangle(int x, int y, int left, int right, int leftHeight, int rightHeight, Bitmap bitmap, Color color)
        {
            X = x;
            Y = y;
            Left = left;
            Right = right;
            LeftHeight = leftHeight;
            RightHeight = rightHeight;
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
