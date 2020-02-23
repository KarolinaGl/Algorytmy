using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    class Heap
    {
        private const int heapSize = 1000;
        private int[] heap;
        private int size;

        public Heap()
        {
            heap = new int[heapSize];
            size = 0;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public int First()
        {
            return heap[1];
        }

        public void Push(int value)
        {
            size++;
            int currentIndex = size;
            heap[size] = value;
            while (heap[currentIndex / 2] > heap[currentIndex] && currentIndex > 1)
            {
                int parentValue = heap[currentIndex / 2];
                heap[currentIndex / 2] = heap[currentIndex];
                heap[currentIndex] = parentValue;
                currentIndex /= 2;
            }
        }

        public int Pop()
        {
            int first = heap[1];
            heap[1] = heap[size];
            size--;
            int currentIndex = 1;
            while(true)
            {
                int smallerChildIndex;
                if (2 * currentIndex + 1 <= size && heap[2 * currentIndex] > heap[2 * currentIndex + 1])
                    smallerChildIndex = 2 * currentIndex + 1;
                else if (2 * currentIndex <= size)
                    smallerChildIndex = 2 * currentIndex;
                else
                    break;

                if (heap[currentIndex] > heap[smallerChildIndex])
                {
                    int temp = heap[smallerChildIndex];
                    heap[smallerChildIndex] = heap[currentIndex];
                    heap[currentIndex] = temp;
                    currentIndex = smallerChildIndex;
                }
                else
                    break;
            }
            return first;
        }
    }
}
