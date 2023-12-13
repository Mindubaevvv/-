using Laba_one.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Policy;
using System.Windows.Forms;

namespace Laba_one
{
    public partial class FigureApp : Form
    {
        Bitmap Bitmap;
        Graphics Graphics;
        Pen Pen;
        Random Random;

        ContainerArr FigureArr; // храним все фигуры тут

        public FigureApp()
        {
            InitializeComponent();
            Bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
            Graphics = Graphics.FromImage(Bitmap);
            Pen = new Pen(Color.Black, 5);
            Random = new Random();
            FigureArr = new ContainerArr();
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
            var figuresWithoutCircles = new ContainerList();
            var figures = FigureArr.Get();

            foreach (var figure in figures)
            {
                if (!(figure is Circle))
                {
                    figuresWithoutCircles.Add(figure);
                }
            }

            FigureArr.Set(figuresWithoutCircles.Get().ToArray());

            for (int i = 0; i < count; i++)
            {
                var circleSize = Random.Next(100, 250);
                var positionY = Random.Next(0, PictureBox.Size.Height - circleSize);
                var positionX = Random.Next(0, PictureBox.Size.Width - circleSize);

                var circle = new Circle(Pen, positionX, positionY, circleSize, PictureBox.Size.Height, PictureBox.Size.Width);
                circle.Draw(Graphics);
                PictureBox.Image = Bitmap;

                FigureArr.Add(circle);
            }
        }

        private void DrawEllipse(int count)
        {
            var figuresWithoutEllipses = new ContainerList();
            var figures = FigureArr.Get();
            foreach (var figure in figures)
            {
                if (!(figure is Ellipse))
                {
                    figuresWithoutEllipses.Add(figure);
                }
            }

            FigureArr.Set(figuresWithoutEllipses.Get().ToArray());

            for (int i = 0; i < count; i++)
            {
                var circleSize = Random.Next(100, 250);
                var positionY = Random.Next(0, PictureBox.Size.Height - circleSize);
                var positionX = Random.Next(0, PictureBox.Size.Width - circleSize);

                var ellipse = new Ellipse(Pen, positionX, positionY, circleSize / 2);
                ellipse.Draw(Graphics);
                PictureBox.Image = Bitmap;

                FigureArr.Add(ellipse);
            }
        }

        private void DrawSquare(int count)
        {
            var figuresWithoutSquares = new List<TFigure>();
            foreach (var figure in Figures)
            {
                if (!(figure is Square))
                {
                    figuresWithoutSquares.Add(figure);
                }
            }

            Figures = figuresWithoutSquares;

            for (int i = 0; i < count; i++)
            {
                var squareSize = Random.Next(100, 250);
                var positionY = Random.Next(0, PictureBox.Size.Height - squareSize);
                var positionX = Random.Next(0, PictureBox.Size.Width - squareSize);

                var squares = new Square(Pen, positionX, positionY, squareSize);
                squares.Draw(Graphics);
                PictureBox.Image = Bitmap;

                Figures.Add(squares);
            }
        }
        private void DrawTriangle(int count)
        {
            var figuresWithoutTriangles = new List<TFigure>();
            foreach (var figure in Figures)
            {
                if (!(figure is Triangle))
                {
                    figuresWithoutTriangles.Add(figure);
                }
            }

            Figures = figuresWithoutTriangles;

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

                Figures.Add(triangles);
            }

        }
        private void DrawRhomb(int count)
        {
            var figuresWithoutRhombes = new List<TFigure>();
            foreach (var figure in Figures)
            {
                if (!(figure is Rhomb))
                {
                    figuresWithoutRhombes.Add(figure);
                }
            }

            Figures = figuresWithoutRhombes;

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

                Figures.Add(rhombes);
            }
        }
        #endregion

        #region MoveAndDraw
        private void MoveAndDrawCircle(Direction direction)
        {
            var circles = new List<Circle>();
            foreach (var figure in Figures)
            {
                if (figure is Circle)
                {
                    circles.Add((Circle)figure);
                }
            }

            foreach (Circle circle in circles)
            {
                circle.Move(direction);
                circle.Draw(Graphics);
                PictureBox.Image = Bitmap;
            }
        }
        private void MoveAndDrawEllipse(Direction direction)
        {
            var ellipses = new List<Ellipse>();
            foreach (var figure in Figures)
            {
                if (figure is Ellipse)
                {
                    ellipses.Add((Ellipse)figure);
                }
            }

            foreach (Ellipse ellipse in ellipses)
            {
                ellipse.Move(direction);
                ellipse.Draw(Graphics);
                PictureBox.Image = Bitmap;
            }
        }
        private void MoveAndDrawSquare(Direction direction)
        {
            var squares = new List<Square>();
            foreach (var figure in FigureArr.Get())
            {
                if (figure is Square)
                {
                    squares.Add((Square)figure);
                }
            }

            foreach (Square square in squares)
            {
                square.Move(direction);
                square.Draw(Graphics);
                PictureBox.Image = Bitmap;
            }
        }
        private void MoveAndDrawTriangle(Direction direction)
        {
            var triangles = new ContainerList();
            foreach (var figure in FigureArr.Get())
            {
                if (figure is Triangle)
                {
                    triangles.Add((Triangle)figure);
                }
            }

            foreach (Triangle triangle in triangles.Get())
            {
                triangle.Move(direction);
                triangle.Draw(Graphics);
                PictureBox.Image = Bitmap;
            }
        }

        private void MoveAndDrawRhomb(Direction direction)
        {
            var rhombesContainer = new ContainerList();
            foreach (var figure in FigureArr.Get())
            {
                if (figure is Rhomb)
                {
                    rhombesContainer.Add((Rhomb)figure);
                }
            }

            foreach (Rhomb rhomb in rhombesContainer.Get())
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
            Figures.Clear();
            PictureBox.Image = null;
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
            var circles = new List<Circle>();
            foreach (var figure in Figures)
            {
                if (figure is Circle)
                {
                    circles.Add((Circle)figure);
                }
            }

            foreach (Circle circle in circles)
            {
                circle.Resize(resizing);
                circle.Draw(Graphics);
                PictureBox.Image = Bitmap;
            }
        }

        private void ChangeandDrawEllipseSize(Resizing resizing)
        {
            var ellipses = new List<Ellipse>();
            foreach (var figure in Figures)
            {
                if (figure is Ellipse)
                {
                    ellipses.Add((Ellipse)figure);
                }
            }

            foreach (Ellipse ellipse in ellipses)
            {
                ellipse.Resize(resizing);
                ellipse.Draw(Graphics);
                PictureBox.Image = Bitmap;
            }
        }
        private void ChangeandDrawSquareSize(Resizing resizing)
        {
            var squares = new List<Square>();
            foreach (var figure in Figures)
            {
                if (figure is Square)
                {
                    squares.Add((Square)figure);
                }
            }

            foreach (Square square in squares)
            {
                square.Resize(resizing);
                square.Draw(Graphics);
                PictureBox.Image = Bitmap;
            }
        }
        private void ChangeandDrawTriangleSize(Resizing resizing)
        {
            var triangles = new List<Triangle>();
            foreach (var figure in Figures)
            {
                if (figure is Triangle)
                {
                    triangles.Add((Triangle)figure);
                }
            }

            foreach (Triangle triangle in triangles)
            {
                triangle.Resize(resizing);
                triangle.Draw(Graphics);
                PictureBox.Image = Bitmap;
            }
        }
        private void ChangeandDrawRhombSize(Resizing resizing)
        {
            var rhombes = new List<Rhomb>();
            foreach (var figure in Figures)
            {
                if (figure is Rhomb)
                {
                    rhombes.Add((Rhomb)figure);
                }
            }

            foreach (Rhomb rhomb in rhombes)
            {
                rhomb.Resize(resizing);
                rhomb.Draw(Graphics);
                PictureBox.Image = Bitmap;
            }
        }
        #endregion

        /*private void btnHide_Click(object sender, EventArgs e)
        {
            foreach (var figure in Figures)
            {
                if (figure is Circle)
                {
                    PictureBox.Image = null;
                }
                else if (figure is Ellipse)
                {
                    PictureBox.Image = null;
                }
                else if (figure is Square)
                {
                    PictureBox.Image = null;
                }
                else if (figure is Triangle)
                {
                    PictureBox.Image = null;
                }
                else if (figure is Rhomb)
                {
                    PictureBox.Image = null;
                }
            }
        }*/

        private void btnShow_Click(object sender, EventArgs e)
        {
            var figures = FigureArr.Get();
            foreach (var figure in figures)
            {
                if (figure is Circle)
                {
                    var circle = (Circle)figure;
                    circle.Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
                else if (figure is Ellipse)
                {
                    var circle = (Ellipse)figure;
                    circle.Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
                else if (figure is Square)
                {
                    var circle = (Square)figure;
                    circle.Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
                else if (figure is Triangle)
                {
                    var circle = (Triangle)figure;
                    circle.Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
                else if (figure is Rhomb)
                {
                    var circle = (Rhomb)figure;
                    circle.Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
            }
        }

        private void btnHide_Click_1(object sender, EventArgs e)
        {
            PictureBox.Image = null;
        }
    }
}