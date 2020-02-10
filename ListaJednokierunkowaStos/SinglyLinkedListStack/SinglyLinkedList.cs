using System;

namespace SinglyLinkedListStack
{
    public class Node<T>
    {
        public Node<T> nextNode;
        public T data;

        public Node(T Data)
        {
            nextNode = null;
            data = Data;
        }
    }

    public class SinglyLinkedList<T>
    {
        private Node<T> list;

        public SinglyLinkedList()
        {
            list = null;
        }

        // O(1)
        public void AddAtTheFront(T Data)
        {
            Node<T> newNode = new Node<T>(Data);
            newNode.nextNode = list;
            list = newNode;
        }

        // O(n)
        public void PrintList()
        {
            Node<T> currentNode = list;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.data);
                currentNode = currentNode.nextNode;
            }
        }

        // O(1)
        public bool IsEmpty()
        {
            return list == null;
        }

        // O(1)
        public T DeleteFirstNode()
        {
            Node<T> firstNode = list;
            if (firstNode != null)
            {
                list = firstNode.nextNode;
                return firstNode.data;
            }
            return default(T);
        }

        // O(n)
        public T DeleteLastNode()
        {
            Node<T> currentNode = list;
            if (list == null)
                return default(T);
            else if (currentNode.nextNode == null)
            {
                list = null;
                return currentNode.data;
            }
            else
            {
                Node<T> previousNode = null;
                while (currentNode.nextNode != null)
                {
                    previousNode = currentNode;
                    currentNode = currentNode.nextNode;
                }
                previousNode.nextNode = null;
                return currentNode.data;
            }
        }

        // O(n)
        public void AddAtTheEnd(T Dane)
        {
            Node<T> newNode = new Node<T>(Dane);
            Node<T> currentNode = list;
            if (currentNode != null)
            {
                while (currentNode.nextNode != null)
                    currentNode = currentNode.nextNode;
                currentNode.nextNode = newNode;
            }
            else
                list = newNode;
        }

        // optymistyczna O(1)
        // pesymistyczna O(n)
        // średnia O(n)
        public T GetNode(int Index)
        {
            Node<T> currentNode = list;
            if (list == null)
                throw new IndexOutOfRangeException();
            for (int i = 0; i < Index; i++)
            {
                if (currentNode.nextNode == null)
                    throw new IndexOutOfRangeException();
                currentNode = currentNode.nextNode;
            }
            return currentNode.data;
        }
    }
}
