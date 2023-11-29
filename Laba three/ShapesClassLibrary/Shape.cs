using System;

namespace ShapesClassLibrary
{
    public abstract class Shape
    {
        protected int X;
        protected int Y;
        protected int Size;
        
        public virtual void Move() { }
        public virtual void Resize() { }
    }

    public class Circle : Shape { }
    public class Ellipse : Circle { }
    public class Square: Ellipse { }
    public class Triangle : Square { }

}
