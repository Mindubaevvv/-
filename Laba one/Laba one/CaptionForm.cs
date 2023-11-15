using Laba_one.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Policy;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Laba_one
{
    public partial class CaptionForm : Form
    {
        Bitmap Bitmap;
        Graphics Graphics;
        Pen Pen;
        Random Random;
        List<Circle> Circles;
        List<Ellipse> Ellipses;
        List<Square> Squares;
        List<Triangle> Triangles;
        private int CircleSize;
        private int SquareSize;
        private int TriangleSize;
        private int PositionY;
        private int PositionX;

        public CaptionForm()
        {
            InitializeComponent();
            Bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
            Graphics = Graphics.FromImage(Bitmap);
            Pen = new Pen(Color.Black, 5);
            Random = new Random();
            Circles = new List<Circle>();
            Ellipses = new List<Ellipse>();
            Squares = new List<Square>();
            Triangles = new List<Triangle>();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            ClearPictureBox();

            var selectedShape = GetSelectedShape();
            DrawShapes(selectedShape, 1);

        }

        private void DrawShapes(ShapeTypes selectedShape, int count)
        {
            switch (selectedShape)
            {
                case ShapeTypes.Circle:
                    DrawCircle(count);
                    break;
                case ShapeTypes.Ellipse:
                    DrawEllipse(count);
                    break;
                case ShapeTypes.Square:
                    DrawSquare(count);
                    break;
                case ShapeTypes.Triangle:
                    DrawTriangle(count);
                    break;
            }
        }

        private void DrawCircle(int count)
        {
            Circles.Clear();

            for (int i = 0; i < count; i++)
            {
                var circleSize = Random.Next(100, 250);
                var positionY = Random.Next(0, PictureBox.Size.Height - circleSize);
                var positionX = Random.Next(0, PictureBox.Size.Width - circleSize);

                var circle = new Circle(Pen, positionX, positionY, circleSize);
                circle.Draw(Graphics);
                PictureBox.Image = Bitmap;

                Circles.Add(circle);
            }
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            ClearPictureBox();
            var selectedShape = GetSelectedShape();
            DrawWithNewPosition(selectedShape, Direction.Left);
        }

        private void DrawWithNewPosition(ShapeTypes selectedShape, Direction direction)
        {
            switch (selectedShape)
            {
                case ShapeTypes.Circle:
                    MoveAndDrawCircle(direction);
                    break;
                case ShapeTypes.Square:
                    break;
                case ShapeTypes.Triangle:
                    break;
                default:
                    //эллипс 
                    break;
            }

        }

        private void MoveAndDrawCircle(Direction direction)
        {
            foreach (Circle circle in Circles)
            {
                circle.Move(direction);
                circle.Draw(Graphics);
                PictureBox.Image = Bitmap;
            }
        }

        private void DrawEllipse(int count)
        {
            for (int i = 0; i < count; i++)
            {
                CircleSize = Random.Next(100, 250);
                PositionY = Random.Next(0, PictureBox.Size.Height - CircleSize);
                PositionX = Random.Next(0, PictureBox.Size.Width - CircleSize);

                Graphics.DrawEllipse(Pen, PositionX, PositionY, CircleSize / 2, CircleSize);
                PictureBox.Image = Bitmap;
            }
        }

        private void DrawSquare(int count)
        {
            for (int i = 0; i < count; i++)
            {
                SquareSize = Random.Next(100, 250);
                PositionY = Random.Next(0, PictureBox.Size.Height - SquareSize);
                PositionX = Random.Next(0, PictureBox.Size.Width - SquareSize);

                Graphics.DrawRectangle(Pen, PositionX, PositionY, SquareSize, SquareSize);
                PictureBox.Image = Bitmap;
            }
        }
        private void DrawTriangle(int count)
        {
            for (int i = 0; i < count; i++)
            {
                TriangleSize = Random.Next(100, 250);
                int x = Random.Next(0, PictureBox.Width - TriangleSize);
                int y = Random.Next(0, PictureBox.Height - TriangleSize);
                Point point1 = new Point(x, y + TriangleSize);
                Point point2 = new Point(x + TriangleSize / 2, y);
                Point point3 = new Point(x + TriangleSize, y + TriangleSize);

                Point[] points = { point1, point2, point3 };

                Graphics.DrawPolygon(Pen, points);
                PictureBox.Image = Bitmap;
            }

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            var selectedShape = GetSelectedShape();
            var count = Random.Next(1, 5);
            DrawShapes(selectedShape, count);
            ClearPictureBox();
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            PictureBox.Image = null;
            PictureBox.Invalidate();
        }
        private void ClearPictureBox()
        {
            Bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
            Graphics = Graphics.FromImage(Bitmap);
        }
        private ShapeTypes GetSelectedShape()
        {
            if (btnCircle.Checked)
            {
                return ShapeTypes.Circle;
            }
            else if (btnEllipse.Checked)
            {
                return ShapeTypes.Ellipse;
            }
            else if (btnSquare.Checked)
            {
                return ShapeTypes.Square;
            }
            else return ShapeTypes.Triangle;
        }
    }
}
