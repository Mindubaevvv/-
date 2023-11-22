using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Laba_one.Shapes
{
    internal class Circle
    {
        private int X;
        private int Y;
        private int Size;
        private Pen Pen;

        public Circle(Pen pen, int x, int y, int size)
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
        public void Draw(Graphics Graphics)
        {
            Graphics.DrawEllipse(Pen, X, Y, Size, Size);
        }
    }
}
