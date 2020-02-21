
namespace SinglyLinkedListStack
{
    public class SinglyLinkedListStack<T> : IStack<T>
    {
        SinglyLinkedList<T> list;

        public SinglyLinkedListStack()
        {
            list = new SinglyLinkedList<T>();
        }

        public void Push(T Data)
        {
            list.AddAtTheFront(Data);
        }

        public T Pop()
        {
            return list.DeleteFirstNode();
        }

        public T Top()
        {
            return list.GetNode(0);
        }

        public bool IsEmpty()
        {
            return list.IsEmpty();
        }
    }
}
