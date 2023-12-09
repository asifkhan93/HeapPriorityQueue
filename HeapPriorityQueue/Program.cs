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
            Console.WriteLine("MinHeap Elements: " + string.Join(", ", minHeap.GetHeap()));
            Console.WriteLine("Extracted Min: " + minHeap.ExtractMin());
            Console.WriteLine("MinHeap Elements: " + string.Join(", ", minHeap.GetHeap()));
            //Console.WriteLine("Extracted Min: " + minHeap.ExtractMin());
            //Console.WriteLine("Heap Elements: " + string.Join(", ", minHeap.GetHeap()));
            //Console.WriteLine("Extracted Min: " + minHeap.ExtractMin());
            //Console.WriteLine("Heap Elements: " + string.Join(", ", minHeap.GetHeap()));

            MaxHeap maxHeap = new MaxHeap();

            maxHeap.Insert(14);
            maxHeap.Insert(19);
            maxHeap.Insert(16);
            maxHeap.Insert(21);
            maxHeap.Insert(26);
            maxHeap.Insert(19);
            maxHeap.Insert(68);
            maxHeap.Insert(65);
            maxHeap.Insert(30);
            Console.WriteLine("MaxHeap Elements: " + string.Join(", ", maxHeap.GetHeap()));
            Console.WriteLine("Extracted Max: " + maxHeap.ExtractMax());
            Console.WriteLine("MaxHeap Elements: " + string.Join(", ", maxHeap.GetHeap()));
        }
    }
}
