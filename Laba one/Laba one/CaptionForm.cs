using Laba_one.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                case ShapeTypes.Сircle:
                    // вызов метода который рисует круг
                    break;
                case ShapeTypes.Ellipse: 
                    break;
                    /// .....


            }
        }


        private ShapeTypes GetSelectedShape()
        {
            if (btnCircle.Checked)
            {
                return ShapeTypes.Сircle;
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


        private void btnMove_Click(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Graphics.Clear(Color.White);
        }

    }
}
