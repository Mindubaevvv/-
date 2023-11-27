using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class CircleForm : Form
    {
        public CircleForm()
        {
            InitializeComponent();
            Size = new Size(400, 400);
            BackColor = Color.White;
        }
        Graphics g;
        private void Form1_Load(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);

            // Создаем объект Graphics для рисования на форме
            Graphics g = e.Graphics;

            // Задаем радиусы большой и малой окружностей
            int bigRadius = 200;
            int smallRadius = 100;

            // Вычисляем координаты центра большой окружности
            int centerX = ClientSize.Width / 2;
            int centerY = ClientSize.Height / 2;

            // Рисуем большую окружность
            g.DrawEllipse(Pens.Black, centerX - bigRadius, centerY - bigRadius, bigRadius * 2, bigRadius * 2);

            // Вычисляем координаты центра малой окружности
            int smallCenterX = centerX + bigRadius - smallRadius;
            int smallCenterY = centerY;

            // Рисуем малую окружность
            g.DrawEllipse(Pens.Red, smallCenterX - smallRadius, smallCenterY - smallRadius, smallRadius * 2, smallRadius * 2);
        }
    }
}
