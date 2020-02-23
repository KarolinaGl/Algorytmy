
namespace SinglyLinkedListStack
{
    public interface IQueue<T>
    {
        public void Push(T Data);

        public T Pop();

        public T Front();

        public bool IsEmpty();
    }
}
