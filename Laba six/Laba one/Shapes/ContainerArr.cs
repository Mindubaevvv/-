using System.Drawing;
using System.Linq;

namespace Laba_one.Shapes
{
    /// <summary>
    /// Контейнер на основе массива
    /// </summary>
    public class ContainerArr : Container
    {
        private TFigure[] Figures;
        public ContainerArr()
        {
            Figures = new TFigure[0];
        }

        public override TFigure[] Get()
        {
            return Figures;
        }
        public override void Add(TFigure figure)
        {
            Figures = Figures.Append(figure).ToArray();            
        }
        public override void Set(TFigure[] figures)
        {
            Figures = figures;
        }

        public override void Move(Direction direction, Graphics graphics)
        {
           foreach (TFigure figure in Figures)
            {
                if (figure is Circle)
                {
                    var circle = (Circle)figure;
                    circle.Move(direction, graphics);
                }
                else if (figure is Ellipse)
                {
                    var ellipse = (Ellipse)figure;
                    ellipse.Move(direction, graphics);
                }
                else if (figure is Square)
                {
                    var square = (Square)figure;
                    square.Move(direction, graphics);
                }
                else if (figure is Rhomb)
                {
                    var rhomb = (Rhomb)figure;
                    rhomb.Move(direction, graphics);
                }
                else if(figure is Triangle)
                {
                    var triangle = (Triangle)figure;
                    triangle.Move(direction, graphics);
                }
            } 
        }

        public override void Resize(Resizing resizing, Graphics graphics)
        {
            foreach (TFigure figure in Figures)
            {
                if (figure is Circle)
                {
                    var circle = (Circle)figure;
                    circle.Resize(resizing, graphics);
                }
                else if (figure is Ellipse)
                {
                    var ellipse = (Ellipse)figure;
                    ellipse.Resize(resizing, graphics);
                }
                else if (figure is Square)
                {
                    var square = (Square)figure;
                    square.Resize(resizing, graphics);
                }
                else if (figure is Rhomb)
                {
                    var rhomb = (Rhomb)figure;
                    rhomb.Resize(resizing, graphics);
                }
                else if (figure is Triangle)
                {
                    var triangle = (Triangle)figure;
                    triangle.Resize(resizing, graphics);
                }
                
            }
        }
    }
}
