using Laba_number_one.Shapes;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace Laba_num_one
{
    public partial class LineForm : Form
    {
        Graphics graphics;
        Line line;
        public LineForm()
        {
            InitializeComponent();
            graphics = this.pctBox.CreateGraphics();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var x = InputX.Text;
            var y = InputY.Text;
            var l = 500;//InputLenght.Text;4
            //line = new Line();
            var pointA = new Point(Convert.ToInt32(x), Convert.ToInt32(y));
            var pointB = new Point(Convert.ToInt32(x) + Convert.ToInt32(l), Convert.ToInt32(y));
            Pen blackkPen = new Pen(Color.Chocolate, 15);
            graphics.DrawLine(blackkPen, pointA, pointB);

        }

        private void LineForm_Load(object sender, EventArgs e)
        {

        }

        private void LineForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
