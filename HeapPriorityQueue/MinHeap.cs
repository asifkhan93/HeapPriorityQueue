using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HeapPriorityQueue
{
    internal class MinHeap
    {
        private List<int> minHeap;
        public MinHeap()
        {
            minHeap = new List<int>();
        }
        public void Insert(int value)
        {
            minHeap.Add(value);
            HeapifyUp();
        }

        private void HeapifyUp() 
        {
            int index = minHeap.Count - 1;

            while (index > 0)
            {
                int parentIndex = (index - 1) / 2;
                if (minHeap[index] >= minHeap[parentIndex])
                    break;

                Swap (index, parentIndex);
                index = parentIndex;
            }
        }

        public int ExtractMin()
        {
            if (minHeap.Count == 0)
                throw new InvalidOperationException("Heap is empty");

            int min = minHeap[0];
            int last = minHeap.Count - 1;

            minHeap[0] = minHeap[last];
            minHeap.RemoveAt(last);
            HeapifyDown();
            return min;
        }
        private void HeapifyDown() 
        {
            int index = 0;

            while (true) 
            {
                int leftChild = 2 * index + 1;
                int rightChild = 2 * index + 2;

                int smallestIndex = index;

                if (leftChild < minHeap.Count &&
                    minHeap[leftChild] < minHeap[smallestIndex]) 
                {
                    smallestIndex = leftChild;
                }
                if (rightChild < minHeap.Count &&
                     minHeap[rightChild] < minHeap[smallestIndex])
                {
                    smallestIndex = rightChild;
                }
                if (smallestIndex == index)
                    break;

                Swap(index, smallestIndex);
                index = smallestIndex;
            }
        }
        private void Swap(int i, int j)
        {
            int temp = minHeap[i];
            minHeap[i] = minHeap[j];
            minHeap[j] = temp;
        }
        public List<int> GetHeap()
        {
            return  new List<int>(minHeap);
        }
    }
}
