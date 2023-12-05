using Laba_one.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Policy;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Laba_one
{
    public partial class FigureApp : Form
    {
        Bitmap Bitmap;
        Graphics Graphics;
        Pen Pen;
        Random Random;
        List<Circle> Circles;
        List<Ellipse> Ellipses;
        List<Square> Squares;
        List<Triangle> Triangles;
        List<Rhomb> Rhombes;

        public FigureApp()
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
            Rhombes = new List<Rhomb>();
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
                case ShapeTypes.Rhomb:
                    DrawRhomb(count);
                    break;
            }
        }
        private void DrawWithNewPosition(ShapeTypes selectedShape, Direction direction)
        {
            switch (selectedShape)
            {
                case ShapeTypes.Circle:
                    MoveAndDrawCircle(direction);
                    break;
                case ShapeTypes.Square:
                    MoveAndDrawSquare(direction);
                    break;
                case ShapeTypes.Triangle:
                    MoveAndDrawTriangle(direction);
                    break;
                case ShapeTypes.Rhomb:
                    MoveAndDrawRhomb(direction);
                    break;
                default:
                    MoveAndDrawEllipse(direction);
                    break;
            }

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
            else if (btnRhomb.Checked)
            {
                return ShapeTypes.Rhomb;
            }
            else return ShapeTypes.Triangle;
        }
        #region Draw
        private void DrawCircle(int count)
        {
            Circles.Clear();

            for (int i = 0; i < count; i++)
            {
                var circleSize = Random.Next(100, 250);
                var positionY = Random.Next(0, PictureBox.Size.Height - circleSize);
                var positionX = Random.Next(0, PictureBox.Size.Width - circleSize);

                var circle = new Circle(Pen, positionX, positionY, circleSize, PictureBox.Size.Height, PictureBox.Size.Width);
                circle.Draw(Graphics);
                PictureBox.Image = Bitmap;

                Circles.Add(circle);
            }
        }

        private void DrawEllipse(int count)
        {
            Ellipses.Clear();

            for (int i = 0; i < count; i++)
            {
                var circleSize = Random.Next(100, 250);
                var positionY = Random.Next(0, PictureBox.Size.Height - circleSize);
                var positionX = Random.Next(0, PictureBox.Size.Width - circleSize);

                var ellipse = new Ellipse(Pen, positionX, positionY, circleSize / 2);
                ellipse.Draw(Graphics);
                PictureBox.Image = Bitmap;

                Ellipses.Add(ellipse);
            }
        }

        private void DrawSquare(int count)
        {
            Squares.Clear();

            for (int i = 0; i < count; i++)
            {
                var squareSize = Random.Next(100, 250);
                var positionY = Random.Next(0, PictureBox.Size.Height - squareSize);
                var positionX = Random.Next(0, PictureBox.Size.Width - squareSize);

                var squares = new Square(Pen, positionX, positionY, squareSize);
                squares.Draw(Graphics);
                PictureBox.Image = Bitmap;

                Squares.Add(squares);
            }
        }
        private void DrawTriangle(int count)
        {
            Triangles.Clear();

            for (int i = 0; i < count; i++)
            {
                var triangleSize = Random.Next(100, 250);
                var x = Random.Next(0, PictureBox.Width - triangleSize);
                var y = Random.Next(0, PictureBox.Height - triangleSize);
                Point point1 = new Point(x, y + triangleSize);
                Point point2 = new Point(x + triangleSize / 2, y);
                Point point3 = new Point(x + triangleSize, y + triangleSize);

                Point[] points = { point1, point2, point3 };

                var triangles = new Triangle(Pen, x, y, triangleSize);
                triangles.Draw(Graphics);
                PictureBox.Image = Bitmap;

                Triangles.Add(triangles);
            }

        }
        private void DrawRhomb(int count)
        {
            Rhombes.Clear();

            for (int i = 0; i < count; i++)
            {
                var rhombSize = Random.Next(100, 250);
                var x = Random.Next(0, PictureBox.Width - rhombSize);
                var y = Random.Next(0, PictureBox.Height - rhombSize);
                Point point1 = new Point(x + rhombSize / 2, y);
                Point point2 = new Point(x + rhombSize, y + rhombSize / 2);
                Point point3 = new Point(x + rhombSize / 2, y + rhombSize);
                Point point4 = new Point(x, y + rhombSize / 2);

                Point[] points = { point1, point2, point3, point4 };

                var rhombes = new Rhomb(Pen, x, y, rhombSize);
                rhombes.Draw(Graphics);
                PictureBox.Image = Bitmap;

                Rhombes.Add(rhombes);
            }
        }
        #endregion

        #region MoveandDraw
        private void MoveAndDrawCircle(Direction direction)
        {
            foreach (Circle circle in Circles)
            {
                circle.Move(direction);
                circle.Draw(Graphics);
                PictureBox.Image = Bitmap;
            }
        }
        private void MoveAndDrawEllipse(Direction direction)
        {
            foreach (Ellipse ellipse in Ellipses)
            {
                ellipse.Move(direction);
                ellipse.Draw(Graphics);
                PictureBox.Image = Bitmap;
            }
        }
        private void MoveAndDrawSquare(Direction direction)
        {
            foreach (Square square in Squares)
            {
                square.Move(direction);
                square.Draw(Graphics);
                PictureBox.Image = Bitmap;
            }
        }
        private void MoveAndDrawTriangle(Direction direction)
        {
            foreach (Triangle triangle in Triangles)
            {
                triangle.Move(direction);
                triangle.Draw(Graphics);
                PictureBox.Image = Bitmap;
            }
        }

        private void MoveAndDrawRhomb(Direction direction)
        {
            foreach (Rhomb rhomb in Rhombes)
            {
                rhomb.Move(direction);
                rhomb.Draw(Graphics);
                PictureBox.Image = Bitmap;
            }
        }
        #endregion

        #region Button
        private void ClearPictureBox()
        {
            Bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
            Graphics = Graphics.FromImage(Bitmap);
        }
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            ClearPictureBox();

            var selectedShape = GetSelectedShape();
            DrawShapes(selectedShape, 1);
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
        private void btnPlus_Click(object sender, EventArgs e)
        {
            ClearPictureBox();
            var selectedShape = GetSelectedShape();
            ChangeSize(selectedShape, Resizing.Plus);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            ClearPictureBox();
            var selectedShape = GetSelectedShape();
            ChangeSize(selectedShape, Resizing.Minus);
        }
        #endregion

        #region Move
        private void btnUp_Click(object sender, EventArgs e)
        {
            ClearPictureBox();
            var selectedShape = GetSelectedShape();
            DrawWithNewPosition(selectedShape, Direction.Up);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            ClearPictureBox();
            var selectedShape = GetSelectedShape();
            DrawWithNewPosition(selectedShape, Direction.Right);
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            ClearPictureBox();
            var selectedShape = GetSelectedShape();
            DrawWithNewPosition(selectedShape, Direction.Left);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            ClearPictureBox();
            var selectedShape = GetSelectedShape();
            DrawWithNewPosition(selectedShape, Direction.Down);

        }
        #endregion

        #region Change
        private void ChangeSize(ShapeTypes selectedShape, Resizing resizing)
        {
            switch (selectedShape)
            {
                case ShapeTypes.Circle:
                    ChangeandDrawCircleSize(resizing);
                    break;
                case ShapeTypes.Square:
                    ChangeandDrawSquareSize(resizing);
                    break;
                case ShapeTypes.Triangle:
                    ChangeandDrawTriangleSize(resizing);
                    break;
                case ShapeTypes.Rhomb:
                    ChangeandDrawRhombSize(resizing);
                    break;
                default:
                    ChangeandDrawEllipseSize(resizing);
                    break;
            }
        }

        private void ChangeandDrawCircleSize(Resizing resizing)
        {
            foreach (Circle circle in Circles)
            {
                circle.Resize(resizing);
                circle.Draw(Graphics);
                PictureBox.Image = Bitmap;
            }
        }

        private void ChangeandDrawEllipseSize(Resizing resizing)
        {
            foreach (Ellipse ellipse in Ellipses)
            {
                ellipse.Resize(resizing);
                ellipse.Draw(Graphics);
                PictureBox.Image = Bitmap;
            }
        }
        private void ChangeandDrawSquareSize(Resizing resizing)
        {
            foreach (Square square in Squares)
            {
                square.Resize(resizing);
                square.Draw(Graphics);
                PictureBox.Image = Bitmap;
            }
        }
        private void ChangeandDrawTriangleSize(Resizing resizing)
        {
            foreach (Triangle triangle in Triangles)
            {
                triangle.Resize(resizing);
                triangle.Draw(Graphics);
                PictureBox.Image = Bitmap;
            }
        }
        private void ChangeandDrawRhombSize(Resizing resizing)
        {
            foreach (Rhomb rhomb in Rhombes)
            {
                rhomb.Resize(resizing);
                rhomb.Draw(Graphics);
                PictureBox.Image = Bitmap;
            }
        }
        #endregion
    }
}