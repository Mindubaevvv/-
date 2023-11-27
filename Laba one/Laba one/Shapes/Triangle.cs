﻿using System;
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
        private Pen Pen;

        public Triangle(Pen pen, int x, int y, int size)
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
            Point point1 = new Point(X, Y + Size);
            Point point2 = new Point(X + Size / 2, Y);
            Point point3 = new Point(X + Size, Y + Size);

            Point[] points = { point1, point2, point3 };
            Graphics.DrawPolygon(Pen, points    );
        }
    }
}
