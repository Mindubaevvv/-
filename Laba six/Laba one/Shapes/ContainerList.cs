using System.Collections.Generic;
using System.Linq;

namespace Laba_one.Shapes
{
    /// <summary>
    /// Контейнер на основе списка
    /// </summary>
    public class ContainerList : Container
    {       
        private IList<TFigure> Figures;

        public ContainerList() 
        {
            Figures = new List<TFigure>();
        }
        public override void Add(TFigure figure)
        {
            Figures.Add(figure);
        }  

        public override TFigure[] Get()
        {
            return Figures.ToArray();
        }

        public override void Set(TFigure[] figures)
        {
            Figures = figures.ToList();
        }
    }
}
