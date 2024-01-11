using System;
using System.Drawing;
using System.Windows.Forms;

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
        public virtual void Move(Direction direction, Graphics graphics) { }
        public virtual void Resize(Resizing resizing, Graphics graphics) { }
        public virtual void Draw(Graphics graphics) { }
    }
}
