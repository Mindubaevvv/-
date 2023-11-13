using Laba_one.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_one
{
    public partial class CaptionForm : Form
    {
        Bitmap Bitmap;
        List<Triangle> Triangles;
        List<Square> Squares;
        List<Ellipse> Ellipses;
        List<Circle> Circles;
        Graphics Graphics;
        Random random = new Random();

        public CaptionForm()
        {
            InitializeComponent();
            Bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics = Graphics.FromImage(Bitmap);
            /*Ellipses = new List<Ellipse>
            {
                new Ellipse(new Pen(Color.Gray, 3f), Bitmap, random.Next(10,200), random.Next(10,200), random.Next(10,200)),
                new Ellipse(new Pen(Color.Gray, 3f), Bitmap, random.Next(10,200), random.Next(10,200), random.Next(10,200)),
                new Ellipse(new Pen(Color.Gray, 3f), Bitmap, random.Next(10,200), random.Next(10,200), random.Next(10,200))
            };
            Circles = new List<Circle>
            {
                new Circle(new Pen(Color.Red, 3f), Bitmap, random.Next(10,200), random.Next(10,200), random.Next(10,200)),
                new Circle(new Pen(Color.Red, 3f), Bitmap, random.Next(10,200), random.Next(10,200), random.Next(10,200)),
                new Circle(new Pen(Color.Red, 3f), Bitmap, random.Next(10,200), random.Next(10,200), random.Next(10,200))
            };
            Triangles = new List<Triangle>
            {
                new Triangle(new Pen(Color.BlueViolet, 3f), Bitmap, random.Next(10,200), random.Next(10,200), random.Next(10,200)),
                new Triangle(new Pen(Color.BlueViolet, 3f), Bitmap, random.Next(10,200), random.Next(10,200), random.Next(10,200)),
                new Triangle(new Pen(Color.BlueViolet, 3f), Bitmap, random.Next(10,200), random.Next(10,200), random.Next(10,200))
            };
            Squares = new List<Square>
            {
                new Square(new Pen(Color.Yellow, 3f), Bitmap, random.Next(10,200), random.Next(10,200), random.Next(10,200)),
                new Square(new Pen(Color.Yellow, 3f), Bitmap, random.Next(10,200), random.Next(10,200), random.Next(10,200)),
                new Square(new Pen(Color.Yellow, 3f), Bitmap, random.Next(10,200), random.Next(10,200), random.Next(10,200)),
                new Square(new Pen(Color.Yellow, 3f), Bitmap, random.Next(10,200), random.Next(10,200), random.Next(10,200))
            };*/

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

        private const int CircleSize = 150; // Размер круга
        private const int WindowSize = CircleSize + 40; // Размер окна
        private int positionY;
        private void DrawCircle()
        {
            Bitmap bitmap = new Bitmap(CircleSize, CircleSize);
            Graphics graphics = Graphics.FromImage(bitmap);

            Pen pen = new Pen(Color.Black, 2); // Цвет и толщина линии

            graphics.DrawEllipse(pen, 0, 0, CircleSize, CircleSize); // Рисуем круг

            pictureBox.Image = bitmap;

            positionY += 10;
            pictureBox.Location = new Point((WindowSize - CircleSize) / 2, positionY);
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
            Bitmap bitmap = new Bitmap(CircleSize, CircleSize);
            Graphics graphics = Graphics.FromImage(bitmap);

            Pen pen = new Pen(Color.Black, 2); // Цвет и толщина линии

            graphics.DrawRectangle(pen, startX, startY, SquareSize, SquareSize);

            pictureBox.Image = bitmap;
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
