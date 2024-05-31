using System;
using System.Collections;
using System.Collections.Generic;

namespace Marketplace
{
    public class HashTable
    {
        private Hashtable table;

        public HashTable(int size)
        {
            table = new Hashtable(size);
        }

        public void Add(string key, marketItem value)
        {
            if (!table.ContainsKey(key))
            {
                table[key] = new List<marketItem>();
            }
            ((List<marketItem>)table[key]).Add(value);
        }

        public marketItem Get(string key)
        {
            if (table.ContainsKey(key))
            {
                return ((List<marketItem>)table[key]).FirstOrDefault();
            }
            return null;
        }

        public void Remove(string key, marketItem value)
        {
            if (table.ContainsKey(key))
            {
                var list = (List<marketItem>)table[key];
                list.Remove(value);
                if (list.Count == 0)
                {
                    table.Remove(key);
                }
            }
        }

        public List<marketItem> SearchByWord(string word)
        {
            if (table.ContainsKey(word))
            {
                return (List<marketItem>)table[word];
            }
            return new List<marketItem>();
        }
    }
}
