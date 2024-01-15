﻿using Laba_one.Shapes;
using System;
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
        bool ShowAllFiguresFlag;
        Container Figures; // храним все фигуры тут, используем контейнер ContainerArr

        public FigureApp()
        {
            InitializeComponent();
            Bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
            Graphics = Graphics.FromImage(Bitmap);
            Pen = new Pen(Color.Black, 5);
            Random = new Random();
            ShowAllFiguresFlag = true;

            // тут меняем реализацию!
            Figures = new ContainerArr();
            //Figures = new ContainerList();
            SetFigures();

            // Для отображения нужно вызвать метод Draw. Мы этот метод скрыли (сделали метод protected) и теперь он нам не доступен
            // Поэтому здесь вызываем Move например, т.к.внутри него вызывается метод Draw. Или вместо него можно вызвать resize.
            Figures.Move(Direction.Right, Graphics);

        }

        private void SetFigures()
        {
            CreateCircles(3);

            CreateEllipses(3);

            CreateSquares(5);

            CreateTriangles(4);

            CreateRhombes(6);

        }

        #region Draw

        private void CreateCircles(int count)
        {
            // удаляем старые круги
            // Буферный контейнер - ContainerList
            var figuresWithoutCircles = new ContainerList();
            foreach (var figure in Figures.Get())
            {
                if (!(figure is Circle))
                {
                    figuresWithoutCircles.Add(figure);
                }
            }
            Figures.Set(figuresWithoutCircles.Get().ToArray());


            //создаем новые и наполняем Figures
            for (int i = 0; i < count; i++)
            {
                var circleSize = Random.Next(100, 250);
                var positionY = Random.Next(0, PictureBox.Size.Height - circleSize);
                var positionX = Random.Next(0, PictureBox.Size.Width - circleSize);

                var circle = new Circle(Pen, positionX, positionY, circleSize, PictureBox.Size.Height, PictureBox.Size.Width);

                Figures.Add(circle);
            }
        }

        private void DrawEllipse()
        {
            foreach (var figure in Figures.Get())
            {
                if (figure is Ellipse)
                {
                    //((Ellipse)figure).Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
            }
        }
        private void CreateEllipses(int count)
        {

            var figuresWithoutEllipses = new ContainerList();
            foreach (var figure in Figures.Get())
            {
                if (!(figure is Ellipse))
                {
                    figuresWithoutEllipses.Add(figure);
                }
            }

            Figures.Set(figuresWithoutEllipses.Get().ToArray());

            for (int i = 0; i < count; i++)
            {
                var ellipseSize = Random.Next(100, 250);
                var positionY = Random.Next(0, PictureBox.Size.Height - ellipseSize);
                var positionX = Random.Next(0, PictureBox.Size.Width - ellipseSize);

                var ellipse = new Ellipse(Pen, positionX, positionY, ellipseSize / 2);

                Figures.Add(ellipse);
            }
        }

        private void DrawSquare()
        {
            foreach (var figure in Figures.Get())
            {
                if (figure is Square)
                {
                    //((Square)figure).Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
            }
        }
        private void CreateSquares(int count)
        {
            var figuresWithoutSquares = new ContainerList();
            foreach (var figure in Figures.Get())
            {
                if (!(figure is Square))
                {
                    figuresWithoutSquares.Add(figure);
                }
            }

            Figures.Set(figuresWithoutSquares.Get().ToArray());

            for (int i = 0; i < count; i++)
            {
                var squareSize = Random.Next(100, 250);
                var positionY = Random.Next(0, PictureBox.Size.Height - squareSize);
                var positionX = Random.Next(0, PictureBox.Size.Width - squareSize);

                var squares = new Square(Pen, positionX, positionY, squareSize);
                //squares.Draw(Graphics);
                //PictureBox.Image = Bitmap;

                Figures.Add(squares);
            }
        }
        private void DrawTriangle()
        {
            foreach (var figure in Figures.Get())
            {
                if (figure is Triangle)
                {
                    //((Triangle)figure).Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
            }
        }
        private void CreateTriangles(int count)
        {
            var figuresWithoutTriangles = new ContainerList();
            foreach (var figure in Figures.Get())
            {
                if (!(figure is Triangle))
                {
                    figuresWithoutTriangles.Add(figure);
                }
            }

            Figures.Set(figuresWithoutTriangles.Get().ToArray());

            for (int i = 0; i < count; i++)
            {
                var triangleSize = Random.Next(100, 250);
                var x = Random.Next(0, PictureBox.Width - triangleSize);
                var y = Random.Next(0, PictureBox.Height - triangleSize);

                var triangle = new Triangle(Pen, x, y, triangleSize);
                //triangles.Draw(Graphics);
                //PictureBox.Image = Bitmap;

                Figures.Add(triangle);
            }
        }
        private void DrawRhomb()
        {
            foreach (var figure in Figures.Get())
            {
                if (figure is Rhomb)
                {
                    //((Rhomb)figure).Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
            }
        }
        private void CreateRhombes(int count)
        {
            var figuresWithoutRhombes = new ContainerList();
            foreach (var figure in Figures.Get())
            {
                if (!(figure is Rhomb))
                {
                    figuresWithoutRhombes.Add(figure);
                }
            }

            Figures.Set(figuresWithoutRhombes.Get().ToArray());

            for (int i = 0; i < count; i++)
            {
                var rhombSize = Random.Next(100, 250);
                var x = Random.Next(0, PictureBox.Width - rhombSize);
                var y = Random.Next(0, PictureBox.Height - rhombSize);

                var rhombes = new Rhomb(Pen, x, y, rhombSize);
                //rhombes.Draw(Graphics);
                //PictureBox.Image = Bitmap;

                Figures.Add(rhombes);
            }
        }
        #endregion

        #region MoveAndDraw
        private void MoveAndDrawCircle(Direction direction)
        {
            var circles = new ContainerList();
            foreach (var figure in Figures.Get())
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

            // Если кнопка "Массив" нажат, отрисовываем все фигуры
            if (ShowAllFiguresFlag)
            {
                ShowAllFigures();
            }
            else // иначе рисуем только круги
            {
                foreach (Circle circle in circles.Get())
                {

                    //circle.Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
            }
        }
        private void MoveAndDrawEllipse(Direction direction)
        {
            var ellipses = new ContainerList();
            foreach (var figure in Figures.Get())
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
                    //ellipse.Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
            }
        }
        private void MoveAndDrawSquare(Direction direction)
        {
            var squares = new ContainerList();
            foreach (var figure in Figures.Get())
            {
                if (figure.GetType() == typeof(Square))
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
                    //square.Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
            }
        }
        private void MoveAndDrawTriangle(Direction direction)
        {
            var triangles = new ContainerList();
            foreach (var figure in Figures.Get())
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
                    //triangle.Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
            }
        }

        private void MoveAndDrawRhomb(Direction direction)
        {
            var rhombes = new ContainerList();
            foreach (var figure in Figures.Get())
            {
                if (figure is Rhomb)
                {
                    rhombes.Add((Rhomb)figure);
                }
            }

            foreach (Rhomb rhomb in rhombes.Get())
            {
                rhomb.Move(direction, Graphics);
            }

            if (ShowAllFiguresFlag)
            {
                ShowAllFigures();
            }
            else
            {
                foreach (Rhomb rhomb in rhombes.Get())
                {
                    //rhomb.Draw(Graphics);
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

            //var selectedShape = GetSelectedShape();
            //DrawShapes(selectedShape, 1);
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            //var selectedShape = GetSelectedShape();
            var count = Random.Next(1, 5);
            //DrawShapes(selectedShape, count);
            ClearPictureBox();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Figures = new ContainerArr();
            PictureBox.Image = null;
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            ClearPictureBox();
            Figures.Resize(Resizing.Plus, Graphics);
            PictureBox.Image = Bitmap;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            ClearPictureBox();
            Figures.Resize(Resizing.Minus, Graphics);
            PictureBox.Image = Bitmap;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            
            ShowAllFigures();
        }
        private void btnHide_Click_1(object sender, EventArgs e)
        {
            PictureBox.Image = null;
        }
        private void btnAllMassive_Click(object sender, EventArgs e)
        {
            Figures = new ContainerArr();            
            SetFigures();

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

        private void button1_Click(object sender, EventArgs e)
        {
            Figures = new ContainerList();
            SetFigures();

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
        #endregion

        #region Move
        private void btnUp_Click(object sender, EventArgs e)
        {
            ClearPictureBox();
            Figures.Move(Direction.Up, Graphics);
            PictureBox.Image = Bitmap;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            ClearPictureBox();
            Figures.Move(Direction.Right, Graphics);
            PictureBox.Image = Bitmap;
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            ClearPictureBox();
            Figures.Move(Direction.Left, Graphics);
            PictureBox.Image = Bitmap;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            ClearPictureBox();
            Figures.Move(Direction.Down, Graphics);
            PictureBox.Image = Bitmap;

        }
        #endregion

        #region Change

        private void ChangeandDrawCircleSize(Resizing resizing)
        {
            var circles = new ContainerList();
            foreach (var figure in Figures.Get())
            {
                if (figure is Circle)
                {
                    circles.Add((Circle)figure);
                }
            }

            foreach (Circle circle in circles.Get())
            {
                //circle.Resize(resizing);
            }

            if (ShowAllFiguresFlag)
            {
                ShowAllFigures();
            }
            else
            {
                foreach (Circle circle in circles.Get())
                {
                    //circle.Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
            }
        }

        private void ChangeandDrawEllipseSize(Resizing resizing)
        {
            var ellipses = new ContainerList();
            foreach (var figure in Figures.Get())
            {
                if (figure is Ellipse)
                {
                    ellipses.Add((Ellipse)figure);
                }
            }

            foreach (Ellipse ellipse in ellipses.Get())
            {
                //ellipse.Resize(resizing);
            }

            if (ShowAllFiguresFlag)
            {
                ShowAllFigures();
            }
            else
            {
                foreach (Ellipse ellipse in ellipses.Get())
                {
                    //ellipse.Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
            }
        }
        private void ChangeandDrawSquareSize(Resizing resizing)
        {
            var squares = new ContainerList();
            foreach (var figure in Figures.Get())
            {
                if (figure is Square)
                {
                    squares.Add((Square)figure);
                }
            }

            foreach (Square square in squares.Get())
            {
                //square.Resize(resizing);
            }

            if (ShowAllFiguresFlag)
            {
                ShowAllFigures();
            }
            else
            {
                foreach (Square square in squares.Get())
                {
                    //square.Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
            }
        }
        private void ChangeandDrawTriangleSize(Resizing resizing)
        {
            var triangles = new ContainerList();
            foreach (var figure in Figures.Get())
            {
                if (figure is Triangle)
                {
                    triangles.Add((Triangle)figure);
                }
            }

            foreach (Triangle triangle in triangles.Get())
            {
                //triangle.Resize(resizing);
            }

            if (ShowAllFiguresFlag)
            {
                ShowAllFigures();
            }
            else
            {
                foreach (Triangle triangle in triangles.Get())
                {
                    //triangle.Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
            }
        }
        private void ChangeandDrawRhombSize(Resizing resizing)
        {
            var rhombes = new ContainerList();
            foreach (var figure in Figures.Get())
            {
                if (figure is Rhomb)
                {
                    rhombes.Add((Rhomb)figure);
                }
            }

            foreach (Rhomb rhomb in rhombes.Get())
            {
                //rhomb.Resize(resizing);
            }

            if (ShowAllFiguresFlag)
            {
                ShowAllFigures();
            }
            else
            {
                foreach (Rhomb rhomb in rhombes.Get())
                {
                    //rhomb.Draw(Graphics);
                    PictureBox.Image = Bitmap;
                }
            }
        }
        #endregion

        private void ShowAllFigures()
        {
            PictureBox.Image = Bitmap;
        }

    }
}