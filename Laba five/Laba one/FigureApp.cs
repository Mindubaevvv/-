using Laba_one.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Laba_one
{
    public partial class FigureApp : Form
    {
        Bitmap Bitmap;
        Graphics Graphics;
        Pen Pen;
        Random Random;
        TFigure[] Figures;
        bool ShowAllFiguresFlag;

        public FigureApp()
        {
            InitializeComponent();
            Bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
            Graphics = Graphics.FromImage(Bitmap);
            Pen = new Pen(Color.Black, 5);
            Random = new Random();
            ShowAllFiguresFlag = true;

            Figures = new TFigure[0];

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
                    CreateTriangles(count);
                    DrawTriangle();
                    break;
                case ShapeTypes.Rhomb:
                    CreateRhombes(count);
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
            foreach (var figure in Figures)
            {
                if (figure is Circle)
                {
                    ((Circle)figure).Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
            }
        }

        // Создание кругов (наполнение Figures новыми кругами)
        private void CreateCircles(int count)
        {
            // удаляем старые круги
            var figuresWithoutCircles = new TFigure[0];
            foreach (var figure in Figures)
            {
                if (!(figure is Circle))
                {
                    figuresWithoutCircles = figuresWithoutCircles.Append(figure).ToArray();
                }
            }
            Figures = figuresWithoutCircles.ToArray();


            //создаем новые и наполняем Figures
            for (int i = 0; i < count; i++)
            {
                var circleSize = Random.Next(100, 250);
                var positionY = Random.Next(0, PictureBox.Size.Height - circleSize);
                var positionX = Random.Next(0, PictureBox.Size.Width - circleSize);

                var circle = new Circle(Pen, positionX, positionY, circleSize, PictureBox.Size.Height, PictureBox.Size.Width);

                Figures = Figures.Append(circle).ToArray();
            }
        }

        private void DrawEllipse()
        {
            foreach (var figure in Figures)
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
            
            var figuresWithoutEllipses = new TFigure[0];
            foreach (var figure in Figures)
            {
                if (!(figure is Ellipse))
                {
                    figuresWithoutEllipses = figuresWithoutEllipses.Append(figure).ToArray();
                }
            }

            Figures = figuresWithoutEllipses.ToArray();

            for (int i = 0; i < count; i++)
            {
                var ellipseSize = Random.Next(100, 250);
                var positionY = Random.Next(0, PictureBox.Size.Height - ellipseSize);
                var positionX = Random.Next(0, PictureBox.Size.Width - ellipseSize);

                var ellipse = new Ellipse(Pen, positionX, positionY, ellipseSize / 2);

                Figures = Figures.Append(ellipse).ToArray();
            }
        }


        private void DrawSquare()
        {
            foreach (var figure in Figures)
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
            var figuresWithoutSquares = new TFigure[0];
            foreach (var figure in Figures)
            {
                if (!(figure is Square))
                {
                    figuresWithoutSquares = figuresWithoutSquares.Append(figure).ToArray();
                }
            }

            Figures = figuresWithoutSquares.ToArray();

            for (int i = 0; i < count; i++)
            {
                var squareSize = Random.Next(100, 250);
                var positionY = Random.Next(0, PictureBox.Size.Height - squareSize);
                var positionX = Random.Next(0, PictureBox.Size.Width - squareSize);

                var squares = new Square(Pen, positionX, positionY, squareSize);
                squares.Draw(Graphics);
                PictureBox.Image = Bitmap;

                Figures = Figures.Append(squares).ToArray();
            }
        }
        private void DrawTriangle()
        {
            foreach (var figure in Figures)
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
            var figuresWithoutTriangles = new TFigure[0];
            foreach (var figure in Figures)
            {
                if (!(figure is Triangle))
                {
                    figuresWithoutTriangles = figuresWithoutTriangles.Append(figure).ToArray();
                }
            }

            Figures = figuresWithoutTriangles.ToArray(); ;

            for (int i = 0; i < count; i++)
            {
                var triangleSize = Random.Next(100, 250);
                var x = Random.Next(0, PictureBox.Width - triangleSize);
                var y = Random.Next(0, PictureBox.Height - triangleSize);

                var triangles = new Triangle(Pen, x, y, triangleSize);
                triangles.Draw(Graphics);
                PictureBox.Image = Bitmap;

                Figures = Figures.Append(triangles).ToArray();
            }
        }
        private void DrawRhomb()
        {
            foreach (var figure in Figures)
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
            var figuresWithoutRhombes = new TFigure[0];
            foreach (var figure in Figures)
            {
                if (!(figure is Rhomb))
                {
                    figuresWithoutRhombes = figuresWithoutRhombes.Append(figure).ToArray();
                }
            }

            Figures = figuresWithoutRhombes.ToArray();

            for (int i = 0; i < count; i++)
            {
                var rhombSize = Random.Next(100, 250);
                var x = Random.Next(0, PictureBox.Width - rhombSize);
                var y = Random.Next(0, PictureBox.Height - rhombSize);

                var rhombes = new Rhomb(Pen, x, y, rhombSize);
                rhombes.Draw(Graphics);
                PictureBox.Image = Bitmap;

                Figures = Figures.Append(rhombes).ToArray();
            }
        }
        #endregion

        #region MoveAndDraw
        private void MoveAndDrawCircle(Direction direction)
        {
            var circles = new TFigure[0];
            foreach (var figure in Figures)
            {
                if (figure is Circle)
                {
                    circles = circles.Append(figure).ToArray();
                }
            }


            foreach (Circle circle in circles)
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
                foreach (Circle circle in circles)
                {

                    circle.Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
            }
        }
        private void MoveAndDrawEllipse(Direction direction)
        {
            var ellipses = new TFigure[0];
            foreach (var figure in Figures)
            {
                if (figure is Ellipse)
                {
                    ellipses = ellipses.Append(figure).ToArray();
                }
            }

            foreach (Ellipse ellipse in ellipses)
            {
                ellipse.Move(direction, Graphics);
            }

            if (ShowAllFiguresFlag)
            {
                ShowAllFigures();
            }
            else 
            {
                foreach (Ellipse ellipse in ellipses)
                {
                    ellipse.Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
            }
        }
        private void MoveAndDrawSquare(Direction direction)
        {
            var squares = new TFigure[0];
            foreach (var figure in Figures)
            {
                if (figure is Square)
                {
                    squares = squares.Append(figure).ToArray();
                }
            }

            foreach (Square square in squares)
            {
                square.Move(direction, Graphics);
            }

            if (ShowAllFiguresFlag)
            {
                ShowAllFigures();
            }
            else
            {
                foreach (Square square in squares)
                {
                    square.Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
            }
        }
        private void MoveAndDrawTriangle(Direction direction)
        {
            var triangles = new TFigure[0];
            foreach (var figure in Figures)
            {
                if (figure is Triangle)
                {
                    triangles = triangles.Append(figure).ToArray();
                }
            }

            foreach (Triangle triangle in triangles)
            {
                triangle.Move(direction, Graphics);
            }

            if (ShowAllFiguresFlag)
            {
                ShowAllFigures();
            }
            else
            {
                foreach (Triangle triangle in triangles)
                {
                    triangle.Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
            }
        }

        private void MoveAndDrawRhomb(Direction direction)
        {
            var rhombes = new TFigure[0];
            foreach (var figure in Figures)
            {
                if (figure is Rhomb)
                {
                    rhombes = rhombes.Append(figure).ToArray();
                }
            }

            foreach (Rhomb rhomb in rhombes)
            {
                rhomb.Move(direction, Graphics);
            }

            if (ShowAllFiguresFlag)
            {
                ShowAllFigures();
            }
            else
            {
                foreach (Rhomb rhomb in rhombes)
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
            Figures = new TFigure[0];
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
        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowAllFigures();
        }
        private void btnHide_Click_1(object sender, EventArgs e)
        {
            PictureBox.Image = null;
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
                    ChangeAndDrawCircleSize(resizing);
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

        private void ChangeAndDrawCircleSize(Resizing resizing)
        {
            var circles = new TFigure[0];
            foreach (var figure in Figures)
            {
                if (figure is Circle)
                {
                    circles = circles.Append(figure).ToArray();
                }
            }

            foreach (Circle circle in circles)
            {
                circle.Resize(resizing);

            }
            if (ShowAllFiguresFlag)
            {
                ShowAllFigures();
            }
            else
            {
                foreach (Circle circle in circles)
                {
                    circle.Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
            }
        }

        private void ChangeandDrawEllipseSize(Resizing resizing)
        {
            var ellipses = new TFigure[0];
            foreach (var figure in Figures)
            {
                if (figure is Ellipse)
                {
                    ellipses = ellipses.Append(figure).ToArray();
                }
            }

            foreach (Ellipse ellipse in ellipses)
            {
                ellipse.Resize(resizing);
            }

            if (ShowAllFiguresFlag)
            {
                ShowAllFigures();
            }
            else
            {
                foreach (Ellipse ellipse in ellipses)
                {
                    ellipse.Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
            }
        }
        private void ChangeandDrawSquareSize(Resizing resizing)
        {
            var squares = new TFigure[0];
            foreach (var figure in Figures)
            {
                if (figure is Square)
                {
                    squares = squares.Append(figure).ToArray();
                }
            }

            foreach (Square square in squares)
            {
                square.Resize(resizing);
            }

            if (ShowAllFiguresFlag)
            {
                ShowAllFigures();
            }
            else
            {
                foreach (Square square in squares)
                {
                    square.Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
            }
        }
        private void ChangeandDrawTriangleSize(Resizing resizing)
        {
            var triangles = new TFigure[0];
            foreach (var figure in Figures)
            {
                if (figure is Triangle)
                {
                    triangles = triangles.Append(figure).ToArray();
                }
            }

            foreach (Triangle triangle in triangles)
            {
                triangle.Resize(resizing);
            }

            if (ShowAllFiguresFlag)
            {
                ShowAllFigures();
            }
            else
            {
                foreach (Triangle triangle in triangles)
                {
                    triangle.Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
            }
        }
        private void ChangeandDrawRhombSize(Resizing resizing)
        {
            var rhombes = new TFigure[0];
            foreach (var figure in Figures)
            {
                if (figure is Rhomb)
                {
                    rhombes = rhombes.Append(figure).ToArray();
                }
            }

            foreach (Rhomb rhomb in rhombes)
            {
                rhomb.Resize(resizing);
            }

            if (ShowAllFiguresFlag)
            {
                ShowAllFigures();
            }
            else
            {
                foreach (Rhomb rhomb in rhombes)
                {
                    rhomb.Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
            }
        }
        #endregion

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

        private void ShowAllFigures()
        {
            foreach (var figure in Figures)
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
    }
}