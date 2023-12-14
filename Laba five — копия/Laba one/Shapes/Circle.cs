using Laba_one.Shapes.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Laba_one.Shapes
{
    class Circle : TFigure
    {
        public Circle(Pen pen, int x, int y, int size, int pictureBoxHeight, int pictureBoxWidth) : base(pen,x,y,size)
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
            graphics.DrawEllipse(new Pen(Color.DarkGreen, 5), X, Y, Size, Size);
        }
    }
}
