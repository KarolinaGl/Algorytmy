
namespace SinglyLinkedListStack
{
    public class SinglyLinkedListQueue<T> : IQueue<T>
    {
        SinglyLinkedList<T> list;

        public SinglyLinkedListQueue()
        {
            list = new SinglyLinkedList<T>();
        }

        public T Front()
        {
            return list.GetNode(0);
        }

        public bool IsEmpty()
        {
            return list.IsEmpty();
        }

        public T Pop()
        {
            return list.DeleteFirstNode();
        }

        public void Push(T Data)
        {
            list.AddAtTheEnd(Data);
        }
    }
}
