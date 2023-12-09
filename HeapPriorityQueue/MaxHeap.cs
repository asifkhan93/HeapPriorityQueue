using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapPriorityQueue
{
    internal class MaxHeap
    {
        private List<int> maxHeap;

        public MaxHeap()
        {
            maxHeap = new List<int>();
        }

        public void Insert(int value) 
        {
            maxHeap.Add(value);
            HeapifyUp();
        }
        private void HeapifyUp()
        {
            int index = maxHeap.Count - 1;

            while (index > 0)
            {
                int parentIndex = (index - 1) / 2;
                if (maxHeap[index] <= maxHeap[parentIndex])
                    break;

                Swap(index, parentIndex);
                index = parentIndex;
            }
        }
        private void Swap(int i, int j)
        {
            int temp = maxHeap[i];
            maxHeap[i] = maxHeap[j];
            maxHeap[j] = temp;
        }
        public List<int> GetHeap()
        {
            return new List<int>(maxHeap);
        }
        public int ExtractMax()
        {
            if (maxHeap.Count == 0) 
            {
                throw new InvalidOperationException("Heap is empty");
            }
            int max = maxHeap[0];
            int last = maxHeap.Count - 1;

            maxHeap[0] = maxHeap[last];
            maxHeap.RemoveAt(last);
            
            HeapifyDown();

            return max;
        }
        private void HeapifyDown()
        {
            int index = 0;

            while (true)
            {
                int leftChildIndex = 2 * index + 1;
                int rightChildIndex = 2 * index + 2;

                int largestIndex = index;

                if (leftChildIndex < maxHeap.Count && maxHeap[leftChildIndex] > maxHeap[largestIndex])
                    largestIndex = leftChildIndex;

                if (rightChildIndex < maxHeap.Count && maxHeap[rightChildIndex] > maxHeap[largestIndex])
                    largestIndex = rightChildIndex;

                if (largestIndex == index)
                    break;

                Swap(index, largestIndex);
                index = largestIndex;
            }
        }
    }
}
