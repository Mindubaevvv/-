using System;

namespace Laba_one.Shapes
{
    /// <summary>
    /// Контейнер для хранения граф. примитивов
    /// </summary>
    public class Container
    {
        public virtual TFigure[] Get() { return null; }

        public virtual void Add(TFigure figures) { }

        public virtual void Set(TFigure[] figures) { }
    }
}
