using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Laba_one.Shapes
{
    internal class Triangle
    {
        private int X;
        private int Y;
        private int Size;
        private bool IsVizible;
        private Bitmap Bitmap;
        private Graphics Graphics;
        private Pen Pen;

        public Triangle(Pen pen, Bitmap bitmap, int x, int y, int size)
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
                Point[] points = new Point[]
                {
                    new Point(X, Y + Size),
                    new Point(X + Size, Y + Size),
                    new Point(X + Size / 2, Y)
                };
                Graphics.DrawPolygon(Pen, points);
            }
            return Bitmap;
        }
    }
}
