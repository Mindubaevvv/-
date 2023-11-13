using Laba_one.Shapes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Laba_one
{
    public partial class CaptionForm : Form
    {
        Bitmap Bitmap;
        Graphics Graphics;
        Pen Pen;
        Random Random;
        private int CircleSize; // Размер круга       
        private int PositionY;
        private int PositionX;

        public CaptionForm()
        {
            InitializeComponent();
            Bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics = Graphics.FromImage(Bitmap);
            Pen = new Pen(Color.Black, 2);
            Random = new Random();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // добавить очистку экрана (удалить все элементы)
            var selectedShape = GetSelectedShape();
            DrawShape(selectedShape);
        }

        private void DrawShape(ShapeTypes selectedShape)
        {
            switch (selectedShape)
            {
                case ShapeTypes.Circle:
                    // вызов метода который рисует круг
                    DrawCircle();
                    break;
                case ShapeTypes.Ellipse:
                    // вызов метода который рисует эллипс
                    DrawEllipse();
                    break;
                case ShapeTypes.Square:
                    // вызов метода который рисует квадрат
                    DrawSquare();
                    break;
                case ShapeTypes.Triangle:
                    // вызов метода который рисует треугольник
                    DrawTriangle();
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
            else return ShapeTypes.Triangle;
        }


        private void DrawCircle()
        {
            // TODO убрать вот эти строки со всех методов. Используем члены которые уже объявлены в самом классе, см вверх!
            // 
            //Bitmap bitmap = new Bitmap(CircleSize, CircleSize);
            //Graphics graphics = Graphics.FromImage(bitmap);
            //Pen pen = new Pen(Color.Black, 2); // Цвет и толщина линии

            //pictureBox.Image = null;
            pictureBox.Dispose();//InitialImage = null;

            CircleSize = Random.Next(100, 250);
            PositionY = Random.Next(0, pictureBox.Size.Height - CircleSize);
            PositionX = Random.Next(0, pictureBox.Size.Width - CircleSize);

            Graphics.DrawEllipse(Pen, PositionX, PositionY, CircleSize, CircleSize); // Рисуем круг

            // TODO 2: Переименовать все контролы: первая буква заглавным pictureBox -> PictureBox
            pictureBox.Image = Bitmap;

            //PositionY += 10;
            //pictureBox.Location = new Point((WindowSize - CircleSize) / 2, positionY);
        }

        private void DrawEllipse()
        {
            Bitmap bitmap = new Bitmap(CircleSize, CircleSize);
            Graphics graphics = Graphics.FromImage(bitmap);

            Pen pen = new Pen(Color.Black, 2); // Цвет и толщина линии

            graphics.DrawEllipse(pen, 0, 0, CircleSize / 2, CircleSize); // Рисуем эллипс

            pictureBox.Image = bitmap;
        }

        private int SquareSize = 100;
        private int startX = 50;
        private int startY = 50;
        private void DrawSquare()
        {
            //Graphics.Clear(Color.White);           
            // Bitmap bitmap = new Bitmap(CircleSize, CircleSize);
            // Graphics graphics = Graphics.FromImage(Bitmap);
            // Pen pen = new Pen(Color.Black, 2); // Цвет и толщина линии

            Graphics.DrawRectangle(Pen, startX, startY, SquareSize, SquareSize);
            pictureBox.Image = Bitmap;
        }

        private int y = 100;
        private void DrawTriangle()
        {

            Bitmap bitmap = new Bitmap(CircleSize, CircleSize);
            Graphics graphics = Graphics.FromImage(bitmap);

            Pen pen = new Pen(Color.Black, 2); // Цвет и толщина линии

            Point[] points = { new Point(10, 10), new Point(100, 10), new Point(50, 100) };

            graphics.DrawPolygon(pen, points);

            pictureBox.Image = bitmap;
        }
        private void btnMove_Click(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void CaptionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
