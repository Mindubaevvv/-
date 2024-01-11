using Laba_one.Shapes.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Laba_one.Shapes
{
    public class Circle : TFigure
    {
        public Circle(Pen pen, int x, int y, int size, int pictureBoxHeight, int pictureBoxWidth) : base(pen,x,y,size)
        {           
            Pen = pen;
            Size = size;
            X = x;
            Y = y;
        }
        public override void Resize(Resizing resizing, Graphics graphics)
        {
            if (resizing == Resizing.Plus)
            {
                Size += 10;
            }
            else
            {
                Size -= 10;
            }
            Draw(graphics);
        }

        protected override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(new Pen(Color.DarkGreen, 5), X, Y, Size, Size);
        }
    }
}
