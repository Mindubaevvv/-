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
    }
}
