using Laba_number_one;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_num_one
{
    public partial class CaptionForm : Form
    {
        public CaptionForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            this.Hide();
            var line = new LineForm();
            line.Show();
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            this.Hide();
            var triangle = new TriangleForm();
            triangle.Show();
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            this.Hide();
            var circle = new CircleForm();
            circle.Show();
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            this.Hide();
            var rectangle = new RectangleForm();
            rectangle.Show();
        }

        private void CaptionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
