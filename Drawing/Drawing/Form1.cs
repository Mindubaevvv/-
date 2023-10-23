namespace Drawing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);

            // Create points that define line.
            PointF point1 = new PointF(100.0F, 100.0F);
            PointF point2 = new PointF(500.0F, 100.0F);

            // Draw line to screen.
            e.Graphics.DrawLine(blackPen, point1, point2);

            // Create pen.
            Pen blackkPen = new Pen(Color.Black, 3);

            //Create location ans size of rectangle
            float x = 200.0F;
            float y = 200.0F;
            float width = 300.0F;
            float height = 200.0F;

            // Draw rectangle to screen.
            e.Graphics.DrawRectangle(blackkPen, x, y, width, height);

            // Create pen.
            Pen blackkPenn = new Pen(Color.Black, 3);

            //Create location ans size of rectangle
            float x1 = 130.0F;
            float y1 = 130.0F;
            float width1 = 200;
            float height1 = 100;

            // Draw ellipse to screen
            e.Graphics.DrawEllipse(blackkPenn, x1, y1, width1, height1);


        }

        Point click;
        Graphics g;

        private void btnDraw_Click(object sender, EventArgs e)
        {


        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            click = e.Location;
            Pen blackkPen = new Pen(Color.Chocolate, 25);
            g.DrawRectangle(blackkPen, click.X, click.Y, 150, 200);
        }
    }
}