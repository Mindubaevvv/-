using System.Collections.Generic;

namespace Laba_one.Shapes
{
    internal class ContainerList
    {
        private List<TFigure> Figures = new List<TFigure>();

        public void Add(TFigure figure)
        {
            Figures.Add(figure);
        }

        public List<TFigure> Get()
        {
            return Figures;
        }        
    }
}
