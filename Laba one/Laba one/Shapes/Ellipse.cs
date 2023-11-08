using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Laba_one.Shapes
{
    internal class Ellipse
    {
        private int X;
        private int Y;
        private int Size;
        private bool IsVizible;
        private Bitmap Bitmap;
        private Graphics Graphics;
        private Pen Pen;

        public Ellipse(Pen pen, Bitmap bitmap, int x, int y, int size)
        {
            IsVizible = true;
            Bitmap = bitmap;
            Size = size;
            Pen = pen;
            X = x;
            Y = y;
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
                Graphics.DrawEllipse(Pen, X, Y, Size / 2, Size);
            }
            return Bitmap;
        }
    }
}
