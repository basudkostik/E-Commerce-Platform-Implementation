using System;
using System.Collections.Generic;
using System.Linq; // Add this for ElementAt

namespace Marketplace
{
    public class MinHeap
    {
        private List<marketItem> heap;

        public MinHeap()
        {
            heap = new List<marketItem>();
        }

        public void Add(marketItem obj)
        {
            heap.Add(obj);
            HeapifyUp(heap.Count - 1);
        }

        public List<marketItem> GetTopN(int n)
        {
            var topN = new List<marketItem>();
            for (int i = 0; i < n; i++)
            {
                if (heap.Count == 0)
                    break;

                topN.Add(heap.ElementAt(0));
                heap[0] = heap.ElementAt(heap.Count - 1);
                heap.RemoveAt(heap.Count - 1);
                HeapifyDown(0);
            }
            return topN;
        }

        private void HeapifyUp(int index)
        {
            int parentIndex = (index - 1) / 2;

            if (parentIndex >= 0 && heap.ElementAt(index).Price < heap.ElementAt(parentIndex).Price)
            {
                Swap(index, parentIndex);
                HeapifyUp(parentIndex);
            }
        }

        private void HeapifyDown(int index)
        {
            int leftChildIndex = 2 * index + 1;
            int rightChildIndex = 2 * index + 2;
            int smallest = index;

            if (leftChildIndex < heap.Count && heap.ElementAt(leftChildIndex).Price < heap.ElementAt(smallest).Price)
            {
                smallest = leftChildIndex;
            }

            if (rightChildIndex < heap.Count && heap.ElementAt(rightChildIndex).Price < heap.ElementAt(smallest).Price)
            {
                smallest = rightChildIndex;
            }

            if (smallest != index)
            {
                Swap(index, smallest);
                HeapifyDown(smallest);
            }
        }

        private void Swap(int index1, int index2)
        {
            marketItem temp = heap.ElementAt(index1);
            heap[index1] = heap.ElementAt(index2);
            heap[index2] = temp;
        }
    }
}
