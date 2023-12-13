
using System.Collections.Generic;
using System.Linq;

namespace Laba_one.Shapes
{
    internal class ContainerArr
    {
        private TFigure[] Figures;
        public ContainerArr()
        {
            Figures = new TFigure[0];
        }

        public TFigure[] Get()
        {
            return Figures;
        }
        public void Add(TFigure figure)
        {
            Figures = Figures.Append(figure).ToArray();            
        }
        public void Set(TFigure[] figures)
        {
            Figures = figures;
        }
    }
}
