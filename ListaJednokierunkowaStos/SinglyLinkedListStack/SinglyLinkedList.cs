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
        public Node<T> head;
        public Node<T> tail;

        public SinglyLinkedList()
        {
            head = null;
            tail = null;
        }

        public T GetLastNode()
        {
            if (tail != null)
                return tail.data;
            return default;
        }

        // O(1)
        public void AddAtTheFront(T Data)
        {
            if (head == null)
            {
                Node<T> newNode = new Node<T>(Data);
                newNode.nextNode = head;
                head = newNode;
                tail = newNode;
            }
            else
            {
                Node<T> newNode = new Node<T>(Data);
                newNode.nextNode = head;
                head = newNode;
            }
        }

        // O(n)
        public void PrintList()
        {
            Node<T> currentNode = head;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.data);
                currentNode = currentNode.nextNode;
            }
        }

        // O(1)
        public bool IsEmpty()
        {
            return head == null;
        }

        // O(1)
        public T DeleteFirstNode()
        {
            Node<T> firstNode = head;
            if (firstNode != null)
            {
                head = firstNode.nextNode;
                if (head == null)
                    tail = null;
                return firstNode.data;
            }
            return default;
        }

        // O(n)
        public T DeleteLastNode()
        {
            Node<T> currentNode = head;
            if (head == null)
                return default;
            else if (currentNode.nextNode == null)
            {
                head = null;
                tail = null;
                return currentNode.data;
            }
            else
            {
                Node<T> previousNode = null;
                while (currentNode.nextNode != null)
                {
                    previousNode = currentNode;
                    currentNode = currentNode.nextNode;
                    tail = previousNode;
                }
                previousNode.nextNode = null;
                return currentNode.data;
            }
        }

        // O(n)
        public void AddAtTheEnd(T Dane)
        {
            Node<T> newNode = new Node<T>(Dane);
            Node<T> currentNode = head;
            if (currentNode != null)
            {
                while (currentNode.nextNode != null)
                    currentNode = currentNode.nextNode;
                currentNode.nextNode = newNode;
                tail = newNode;
            }
            else
            {
                head = newNode;
                tail = newNode;
            }
        }

        // optymistyczna O(1)
        // pesymistyczna O(n)
        // średnia O(n)
        public T GetNode(int Index)
        {
            Node<T> currentNode = head;
            if (head == null)
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
