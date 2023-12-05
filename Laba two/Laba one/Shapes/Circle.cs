using Laba_one.Shapes.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Laba_one.Shapes
{
    internal class Circle
    {
        private ClassPoint Point;
        private int Size;
        private Pen Pen;

        public Circle(Pen pen, int x, int y, int size, int pictureBoxHeight, int pictureBoxWidth)
        {
            Pen = pen;
            Size = size;
            Point = new Helpers.ClassPoint(x, y, pictureBoxHeight - Size, pictureBoxWidth - Size);
        }
        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Left:
                    if(Point.X - 20 < Point.MinX)
                    {
                        Point.X = Point.MinX;
                    }
                    else
                    {
                        Point.X -= 20;
                    }
                    break;

                case Direction.Right:
                    if (Point.X + 20 > Point.MaxX)
                    {

                    }
                    else
                    {
                        Point.X += 20;
                    }
                    break;

                case Direction.Up:
                    if (Point.Y - 20 < Point.MinY)
                    {

                    }
                    else
                    {
                        Point.Y -= 20;
                    }
                    break;

                default: 
                    if (Point.Y > Point.MaxY)
                    {

                    }
                    else
                    {
                        Point.Y += 20;
                    }
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
            var smallCircleSize = Size - 50;
            var y1 = Point.Y + (Size - smallCircleSize) / 2;
            var x1 = Point.X + (Size - smallCircleSize) / 2;
            Graphics.DrawEllipse(Pen, x1, y1, smallCircleSize, smallCircleSize);
            Graphics.DrawEllipse(Pen, Point.X, Point.Y, Size, Size);
        }
    }
}
