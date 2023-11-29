using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Laba_one.Shapes
{
    abstract class TFigure
    {
        protected int X;
        protected int Y;
        protected int Size;
        protected Pen Pen;

        public TFigure(Pen pen, int x, int y, int size)
        {
            Pen = pen;
            X = x;
            Y = y;
            Size = size;
        }

        public abstract void Resize();
        public abstract void Draw();
    }
}
