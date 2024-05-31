using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Marketplace
{
    public class List : IEnumerable
    {
        private object[] items;
        private int count;

        public List()
        {
            items = new object[4];
            count = 0;
        }

        public int Count => count;

        public void Add(object item)
        {
            if (count == items.Length)
                Array.Resize(ref items, items.Length * 2);
            items[count++] = item;
        }

        public void Remove(object item)
        {
            int index = Array.IndexOf(items, item, 0, count);
            if (index >= 0)
            {
                RemoveAt(index);
            }
        }

        public void RemoveAt(int index)
        {
            if (index >= 0 && index < count)
            {
                for (int i = index; i < count - 1; i++)
                    items[i] = items[i + 1];
                count--;
            }
        }

        public bool Contains(object item)
        {
            return Array.IndexOf(items, item, 0, count) >= 0;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
                yield return items[i];
        }

        public void AddRange(IEnumerable<object> collection)
        {
            foreach (var item in collection)
            {
                Add(item);
            }
        }

        // Placeholder for the buckets example
        public void AddItemsFromBuckets(IEnumerable<IEnumerable<object>> buckets)
        {
            foreach (var bucket in buckets)
            {
                AddRange(bucket);
            }
        }
    }
}
