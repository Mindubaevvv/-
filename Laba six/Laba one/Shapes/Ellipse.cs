using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Laba_one.Shapes
{
    class Ellipse : Circle
    {
        public Ellipse(Pen pen, int x, int y, int size) : base(pen, x, y, size, 0, 0)
        {
            Pen = pen;
            Size = size;
            X = x;
            Y = y;
        }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(new Pen(Color.DarkBlue, 5), X, Y, Size, Size / 2);
        }
    }
}
