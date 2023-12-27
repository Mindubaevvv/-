using System;

namespace Laba_one.Shapes
{
    /// <summary>
    /// Контейнер для хранения граф. примитивов
    /// </summary>
    public abstract class Container
    {
        public abstract TFigure[] Get();
      
        public abstract void Add(TFigure figures);

        public abstract void Set(TFigure[] figures);
        
    }
}
