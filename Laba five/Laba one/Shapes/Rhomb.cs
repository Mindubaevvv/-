using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Laba_one.Shapes
{
    class Rhomb : Square
    {

        public Rhomb(Pen pen, int x, int y, int size) : base(pen, x, y, size)
        {
            Pen = pen;
            Size = size;
            X = x;
            Y = y;
        }
        /*public override void Move(Direction direction)
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
        }*/
        public override void Resize(Resizing resizing)
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
            Point point1 = new Point(X + Size / 2, Y);
            Point point2 = new Point(X + Size, Y + Size / 2);
            Point point3 = new Point(X + Size / 2, Y + Size);
            Point point4 = new Point(X, Y + Size / 2);

            Point[] points = { point1, point2, point3, point4 };
            graphics.DrawPolygon(new Pen(Color.DarkOrchid, 5), points);
        }
    }
}
