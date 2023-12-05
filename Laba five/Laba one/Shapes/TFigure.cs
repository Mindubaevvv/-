using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Laba_one.Shapes
{
    abstract class TFigure
    {
        protected int X;
        protected int Y;
        protected int Size;
        protected Pen Pen;

        // нужно сделать один массив всех фигур, с которым я будешь взаимодействовать.
        // нужно добавить функционал добавления, показа, стирания, уничтножения всех фигур в массиве.

        public TFigure(Pen pen, int x, int y, int size)
        {
            Pen = pen;
            X = x;
            Y = y;
            Size = size;
        }

        public virtual void Resize() { }
        public virtual void Draw() { }
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
            Draw();
        }

    }
}
