using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Laba_one.Shapes
{
    class Square : TFigure
    {
        public Square(Pen pen, int x, int y, int size) : base(pen, x, y, size)
        {
            Pen = pen;
            Size = size;
            X = x;
            Y = y;
        }
        public void Resize(Resizing resizing)
        {
            if (resizing == Resizing.Plus)
            {
                Size += 10;
            }
            else
            {
                Size -= 10;
            }
        }
        public void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(new Pen(Color.DarkRed, 5), X, Y, Size, Size);
        }
    }
}
