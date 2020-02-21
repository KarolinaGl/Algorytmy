
namespace SinglyLinkedListStack
{
    public interface IStack<T>
    {
        public void Push(T Data);

        public T Pop();

        public T Top();

        public bool IsEmpty();
    }
}
