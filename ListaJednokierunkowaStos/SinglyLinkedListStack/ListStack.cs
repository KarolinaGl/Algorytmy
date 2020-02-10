using System.Collections.Generic;

namespace SinglyLinkedListStack
{
    public class ListStack<T> : IStack<T>
    {
        List<T> list;

        public ListStack()
        {
            list = new List<T>();
        }

        public bool IsEmpty()
        {
            return list.Count == 0;
        }

        public T Pop()
        {
            T elementToPop = list[list.Count-1];
            list.Remove(list[list.Count-1]);
            return elementToPop;
        }

        public void Push(T dane)
        {
            list.Add(dane);
        }

        public T Top()
        {
            return list[list.Count-1];
        }
    }
}
