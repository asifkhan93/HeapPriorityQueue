using System;

namespace HeapPriorityQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MinHeap minHeap = new MinHeap();

            minHeap.Insert(14);
            minHeap.Insert(19);
            minHeap.Insert(16);
            minHeap.Insert(21);
            minHeap.Insert(26);
            minHeap.Insert(19);
            minHeap.Insert(68);
            minHeap.Insert(65);
            minHeap.Insert(30);

            Console.Write("Heap Elements: " + string.Join(", ", minHeap.GetHeap()));

        }
    }
}
