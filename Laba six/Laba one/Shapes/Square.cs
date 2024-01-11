using System.Drawing;

namespace Laba_one.Shapes
{
    public class Square : TFigure
    {
        public Square(Pen pen, int x, int y, int size) : base(pen, x, y, size)
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
            graphics.DrawRectangle(new Pen(Color.DarkRed, 5), X, Y, Size, Size);
        }

    }
}
