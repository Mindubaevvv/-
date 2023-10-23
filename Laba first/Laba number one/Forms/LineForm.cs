using Laba_number_one.Shapes;
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
    public partial class LineForm : Form
    {
        public LineForm()
        {
            InitializeComponent();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var x = InputX.Text;
            var y = InputY.Text;

        }

        private void LineForm_Load(object sender, EventArgs e)
        {
        
        }
    }
}
