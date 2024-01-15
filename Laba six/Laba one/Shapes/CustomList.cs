using System.Linq;

namespace Laba_one.Shapes
{

    public class CustomList<T>
    {
        private T[] MyList;
        public CustomList()
        {
            MyList = new T[0];
        }

        public void Add(T item)
        {
            MyList.Append(item);
        }

        public T[] ToArray()
        {
            return MyList;
        }

        public void Set(T[] newList)
        {
            MyList = newList;
        }               
    }
}
