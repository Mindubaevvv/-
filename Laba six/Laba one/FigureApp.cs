using Laba_one.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
        bool ShowAllFiguresFlag;
        ContainerArr FigureArr; // храним все фигуры тут, используем контейнер ContainerArr

        public FigureApp()
        {
            InitializeComponent();
            Bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
            Graphics = Graphics.FromImage(Bitmap);
            Pen = new Pen(Color.Black, 5);
            Random = new Random();
            FigureArr = new ContainerArr();

            CreateCircles(3);
            DrawCircle();

            CreateEllipses(3);
            DrawEllipse();

            CreateSquares(5);
            DrawSquare();

            CreateTriangles(4);
            DrawTriangle();

            CreateRhombes(6);
            DrawRhomb();
        }

        private void DrawShapes(ShapeTypes selectedShape, int count)
        {
            switch (selectedShape)
            {
                case ShapeTypes.Circle:
                    CreateCircles(count);
                    DrawCircle();
                    break;
                case ShapeTypes.Ellipse:
                    CreateEllipses(count);
                    DrawEllipse();
                    break;
                case ShapeTypes.Square:
                    CreateSquares(count);
                    DrawSquare();
                    break;
                case ShapeTypes.Triangle:
                    CreateCircles(count);
                    DrawTriangle();
                    break;
                case ShapeTypes.Rhomb:
                    CreateCircles(count);
                    DrawRhomb();
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
        private void DrawCircle()
        {
            // получаем круги из Figures и отрисовываем           
            foreach (var figure in FigureArr.Get())
            {
                if (figure is Circle)
                {
                    ((Circle)figure).Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
            }
        }
        private void CreateCircles(int count)
        {
            // удаляем старые круги
            var figuresWithoutCircles = new ContainerList();  // Буферный контейнер - ContainerList
            foreach (var figure in FigureArr.Get())
            {
                if (!(figure is Circle))
                {
                    figuresWithoutCircles.Get().Append(figure).ToArray();
                }
            }
            FigureArr.Get().ToArray();


            //создаем новые и наполняем Figures
            for (int i = 0; i < count; i++)
            {
                var circleSize = Random.Next(100, 250);
                var positionY = Random.Next(0, PictureBox.Size.Height - circleSize);
                var positionX = Random.Next(0, PictureBox.Size.Width - circleSize);

                var circle = new Circle(Pen, positionX, positionY, circleSize, PictureBox.Size.Height, PictureBox.Size.Width);

                FigureArr.Get().Append(circle).ToArray();
            }
        }

        private void DrawEllipse()
        {
            foreach (var figure in FigureArr.Get())
            {
                if (figure is Ellipse)
                {
                    ((Ellipse)figure).Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
            }
        }
        private void CreateEllipses(int count)
        {

            var figuresWithoutEllipses = new ContainerList();
            foreach (var figure in FigureArr.Get())
            {
                if (!(figure is Ellipse))
                {
                    figuresWithoutEllipses.Get().Append(figure).ToArray();
                }
            }

            FigureArr.Get().ToArray();

            for (int i = 0; i < count; i++)
            {
                var ellipseSize = Random.Next(100, 250);
                var positionY = Random.Next(0, PictureBox.Size.Height - ellipseSize);
                var positionX = Random.Next(0, PictureBox.Size.Width - ellipseSize);

                var ellipse = new Ellipse(Pen, positionX, positionY, ellipseSize / 2);

                FigureArr.Get().Append(ellipse).ToArray();
            }
        }

        private void DrawSquare()
        {
            foreach (var figure in FigureArr.Get())
            {
                if (figure is Square)
                {
                    ((Square)figure).Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
            }
        }
        private void CreateSquares(int count)
        {
            var figuresWithoutSquares = new ContainerList();
            foreach (var figure in FigureArr.Get())
            {
                if (!(figure is Square))
                {
                    figuresWithoutSquares.Get().Append(figure).ToArray();
                }
            }

            FigureArr.Get().ToArray();

            for (int i = 0; i < count; i++)
            {
                var squareSize = Random.Next(100, 250);
                var positionY = Random.Next(0, PictureBox.Size.Height - squareSize);
                var positionX = Random.Next(0, PictureBox.Size.Width - squareSize);

                var squares = new Square(Pen, positionX, positionY, squareSize);
                squares.Draw(Graphics);
                PictureBox.Image = Bitmap;

                FigureArr.Get().Append(squares).ToArray();
            }
        }
        private void DrawTriangle()
        {
            foreach (var figure in FigureArr.Get())
            {
                if (figure is Triangle)
                {
                    ((Triangle)figure).Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
            }
        }
        private void CreateTriangles(int count)
        {
            var figuresWithoutTriangles = new ContainerList();
            foreach (var figure in FigureArr.Get())
            {
                if (!(figure is Triangle))
                {
                    figuresWithoutTriangles.Get().Append(figure).ToArray();
                }
            }

            FigureArr.Get().ToArray(); ;

            for (int i = 0; i < count; i++)
            {
                var triangleSize = Random.Next(100, 250);
                var x = Random.Next(0, PictureBox.Width - triangleSize);
                var y = Random.Next(0, PictureBox.Height - triangleSize);

                var triangles = new Triangle(Pen, x, y, triangleSize);
                triangles.Draw(Graphics);
                PictureBox.Image = Bitmap;

                FigureArr.Get().Append(triangles).ToArray();
            }
        }
        private void DrawRhomb()
        {
            foreach (var figure in FigureArr.Get())
            {
                if (figure is Rhomb)
                {
                    ((Rhomb)figure).Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
            }
        }
        private void CreateRhombes(int count)
        {
            var figuresWithoutRhombes = new ContainerList();
            foreach (var figure in FigureArr.Get())
            {
                if (!(figure is Rhomb))
                {
                    figuresWithoutRhombes.Get().Append(figure).ToArray();
                }
            }

            FigureArr.Get().ToArray();

            for (int i = 0; i < count; i++)
            {
                var rhombSize = Random.Next(100, 250);
                var x = Random.Next(0, PictureBox.Width - rhombSize);
                var y = Random.Next(0, PictureBox.Height - rhombSize);

                var rhombes = new Rhomb(Pen, x, y, rhombSize);
                rhombes.Draw(Graphics);
                PictureBox.Image = Bitmap;

                FigureArr.Get().Append(rhombes).ToArray();
            }
        }
        #endregion

        #region MoveAndDraw
        private void MoveAndDrawCircle(Direction direction)
        {
            var circles = new ContainerList();
            foreach (var figure in FigureArr.Get())
            {
                if (figure is Circle)
                {
                    circles.Add((Circle)figure);
                }
            }

            foreach (Circle circle in circles.Get())
            {
                circle.Move(direction, Graphics);
                
            }

            // Если кнопка "Массив" нажата, отрисовываем все фигуры
            if (ShowAllFiguresFlag)
            {
                ShowAllFigures();
            }
            else // иначе рисуем только круги
            {
                foreach (Circle circle in circles.Get())
                {

                    circle.Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
            }
        }
        private void MoveAndDrawEllipse(Direction direction)
        {
            var ellipses = new ContainerList();
            foreach (var figure in FigureArr.Get())
            {
                if (figure is Ellipse)
                {
                    ellipses.Add((Ellipse)figure);
                }
            }

            foreach (Ellipse ellipse in ellipses.Get())
            {
                ellipse.Move(direction, Graphics);
            }

            if (ShowAllFiguresFlag)
            {
                ShowAllFigures();
            }
            else
            {
                foreach (Ellipse ellipse in ellipses.Get())
                {
                    ellipse.Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
            }
        }
        private void MoveAndDrawSquare(Direction direction)
        {
            var squares = new ContainerList();
            foreach (var figure in FigureArr.Get())
            {
                if (figure is Square)
                {
                    squares.Add((Square)figure);
                }
            }

            foreach (Square square in squares.Get())
            {
                square.Move(direction, Graphics);
            }

            if (ShowAllFiguresFlag)
            {
                ShowAllFigures();
            }
            else
            {
                foreach (Square square in squares.Get())
                {
                    square.Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
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
                triangle.Move(direction, Graphics);
            }

            if (ShowAllFiguresFlag)
            {
                ShowAllFigures();
            }
            else
            {
                foreach (Triangle triangle in triangles.Get())
                {
                    triangle.Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
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
                rhomb.Move(direction, Graphics);
            }

            if (ShowAllFiguresFlag)
            {
                ShowAllFigures();
            }
            else
            {
                foreach (Rhomb rhomb in rhombesContainer.Get())
                {
                    rhomb.Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
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
            FigureArr = new ContainerArr();
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
            var circles = new ContainerList();
            foreach (var figure in FigureArr.Get())
            {
                if (figure is Circle)
                {
                    circles.Add((Circle)figure);
                }
            }

            foreach (Circle circle in circles.Get())
            {
                circle.Resize(resizing);
            }

            if (ShowAllFiguresFlag)
            {
                ShowAllFigures();
            }
            else
            {
                foreach (Circle circle in circles.Get())
                {
                    circle.Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
            }
        }

        private void ChangeandDrawEllipseSize(Resizing resizing)
        {
            var ellipses = new ContainerList();
            foreach (var figure in FigureArr.Get())
            {
                if (figure is Ellipse)
                {
                    ellipses.Add((Ellipse)figure);
                }
            }

            foreach (Ellipse ellipse in ellipses.Get())
            {
                ellipse.Resize(resizing);
            }

            if (ShowAllFiguresFlag)
            {
                ShowAllFigures();
            }
            else
            {
                foreach (Ellipse ellipse in ellipses.Get())
                {
                    ellipse.Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
            }
        }
        private void ChangeandDrawSquareSize(Resizing resizing)
        {
            var squares = new ContainerList();
            foreach (var figure in FigureArr.Get())
            {
                if (figure is Square)
                {
                    squares.Add((Square)figure);
                }
            }

            foreach (Square square in squares.Get())
            {
                square.Resize(resizing);
            }

            if (ShowAllFiguresFlag)
            {
                ShowAllFigures();
            }
            else
            {
                foreach (Square square in squares.Get())
                {
                    square.Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
            }
        }
        private void ChangeandDrawTriangleSize(Resizing resizing)
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
                triangle.Resize(resizing);
            }

            if (ShowAllFiguresFlag)
            {
                ShowAllFigures();
            }
            else
            {
                foreach (Triangle triangle in triangles.Get())
                {
                    triangle.Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
            }
        }
        private void ChangeandDrawRhombSize(Resizing resizing)
        {
            var rhombes = new ContainerList();
            foreach (var figure in FigureArr.Get())
            {
                if (figure is Rhomb)
                {
                    rhombes.Add((Rhomb)figure);
                }
            }

            foreach (Rhomb rhomb in rhombes.Get())
            {
                rhomb.Resize(resizing);
            }

            if (ShowAllFiguresFlag)
            {
                ShowAllFigures();
            }
            else
            {
                foreach (Rhomb rhomb in rhombes.Get())
                {
                    rhomb.Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
            }
        }
        #endregion

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

        private void ShowAllFigures()
        {
            foreach (var figure in FigureArr.Get())
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

        private void btnAllMassive_Click(object sender, EventArgs e)
        {
            if (ShowAllFiguresFlag == true)
            {
                ShowAllFiguresFlag = false;
                PictureBox.Image = null; // скрываем фигуры
            }
            else
            {
                ShowAllFiguresFlag = true;
                ShowAllFigures();
            }
        }
    }
}