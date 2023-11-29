using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Laba_one.Shapes
{
    class Ellipse : Circle
    {

        public Ellipse(Pen pen, int x, int y, int size)
        {
            Pen = pen;
            Size = size;
            X = x;
            Y = y;
        }
        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Left:
                    X -= 20;
                    break;

                case Direction.Right:
                    X += 20;
                    break;

                case Direction.Up:
                    Y -= 20;
                    break;

                default: // down
                    Y += 20;
                    break;
            }
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
        public void Draw(Graphics Graphics)
        {
            Graphics.DrawEllipse(Pen, X, Y, Size / 2, Size);
        }
    }
}
