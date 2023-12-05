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
        protected int MaxX;
        protected int MinX;
        protected int MaxY;
        protected int MinY;

        protected CirclePoint Point;

        public Circle(Pen pen, int x, int y, int size, int pictureBoxHeight, int pictureBoxWidth) : base(pen,x,y,size)
        {           
            Point = new CirclePoint(x, y, pictureBoxHeight - Size, pictureBoxWidth - Size);
        }
        /*public override void Move(Direction direction)
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
            var smallCircleSize = Size - 50;
            var y1 = Point.Y + (Size - smallCircleSize) / 2;
            var x1 = Point.X + (Size - smallCircleSize) / 2;
            //graphics.DrawEllipse(new Pen(Color.DarkGreen, 5), x1, y1, smallCircleSize, smallCircleSize);
            graphics.DrawEllipse(new Pen(Color.DarkGreen, 5), Point.X, Point.Y, Size, Size);
        }
    }
}
