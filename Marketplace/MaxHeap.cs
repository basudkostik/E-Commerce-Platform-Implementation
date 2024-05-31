using System;
using System.Collections.Generic;
using System.Linq;

namespace Marketplace
{
    public class MaxHeap
    {
        private List<marketItem> items = new List<marketItem>();

        public int Count => items.Count;

        public void Add(marketItem item)
        {
            items.Add(item);
            HeapifyUp(items.Count - 1);
        }

        public marketItem RemoveRoot()
        {
            if (items.Count == 0)
                throw new InvalidOperationException("Heap is empty.");

            marketItem root = items[0];
            items[0] = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            HeapifyDown(0);

            return root;
        }

        public void Remove(marketItem item)
        {
            int index = items.IndexOf(item);
            if (index == -1) return;

            items[index] = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);

            if (index < items.Count)
            {
                HeapifyUp(index);
                HeapifyDown(index);
            }
        }

        public IEnumerable<marketItem> GetTopNCheapest(string category, int n)
        {
            var results = new List<marketItem>();
            var tempHeap = new MaxHeap();
            foreach (var item in items)
            {
                if (item.Category == category)
                {
                    tempHeap.Add(item);
                }
            }

            for (int i = 0; i < n && tempHeap.Count > 0; i++)
            {
                results.Add(tempHeap.RemoveRoot());
            }

            return results;
        }

        private void HeapifyUp(int index)
        {
            int parentIndex = (index - 1) / 2;
            while (index > 0 && items[index].CompareTo(items[parentIndex]) > 0)
            {
                Swap(index, parentIndex);
                index = parentIndex;
                parentIndex = (index - 1) / 2;
            }
        }

        private void HeapifyDown(int index)
        {
            int lastIndex = items.Count - 1;
            while (index < lastIndex)
            {
                int leftChildIndex = 2 * index + 1;
                int rightChildIndex = 2 * index + 2;

                if (leftChildIndex > lastIndex)
                    break;

                int swapIndex = leftChildIndex;
                if (rightChildIndex <= lastIndex && items[rightChildIndex].CompareTo(items[leftChildIndex]) > 0)
                {
                    swapIndex = rightChildIndex;
                }

                if (items[index].CompareTo(items[swapIndex]) >= 0)
                    break;

                Swap(index, swapIndex);
                index = swapIndex;
            }
        }

        private void Swap(int index1, int index2)
        {
            marketItem temp = items[index1];
            items[index1] = items[index2];
            items[index2] = temp;
        }
    }
}
