using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Laba_one.Shapes
{
    internal class Circle
    {
        private int X;
        private int Y;
        private int Size;
        private bool IsVizible;
        private Bitmap Bitmap;
        private Pen Pen;
        private Graphics Graphics;

        public Circle(Bitmap bitmap, Pen pen, int x, int y, int size)
        {
            Bitmap = bitmap;
            Pen = pen;
            Size = size;
            X = x;
            Y = y;
            IsVizible = true;
            Graphics = Graphics.FromImage(bitmap);
        }

        public void Hide(bool state)
        {
            IsVizible = state;
        }

        public bool ISVizible()
        {
            return IsVizible;
        }

        public void Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        public virtual Bitmap Draw()
        {
            if (IsVizible)
            {
                Graphics.DrawEllipse(Pen, X, Y, Size, Size);
            }
            return Bitmap;
        }

    }
}
