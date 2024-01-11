using System.Drawing;

namespace Laba_one.Shapes
{
    public abstract class TFigure
    {
        protected int X;
        protected int Y;
        protected int Size;
        protected Pen Pen;

        public TFigure(Pen pen, int x, int y, int size)
        {
            Pen = pen;
            X = x;
            Y = y;
            Size = size;
        }

        public abstract void Resize(Resizing resizing, Graphics graphics);
        protected abstract void Draw(Graphics graphics);
        public void Move(Direction direction, Graphics graphics)
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
            Draw(graphics);
        }

    }
}
