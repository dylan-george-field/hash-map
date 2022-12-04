using System;
using System.Collections.Generic;
namespace ConsolePlayground
{
    internal class KeyValue
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return Key + ":" + Value;
        }
    }

    internal class HashMap
    {
        private LinkedList<KeyValue>[] lists;
        private readonly int _size = 0;

        private const int DefaultSize = 10;

        public HashMap() : this(DefaultSize) { }

        public HashMap(int size)
        {
            _size = size;
            lists = new LinkedList<KeyValue>[size];
        }

        public void Put(KeyValue pair)
        {
            var index = GetIndex(pair.Key);

            var _ = GetLinkedList(index);

            lists[index].AddFirst(pair);
        }


        public KeyValue Get(string key)
        {
            var index = GetIndex(key);

            var list = GetLinkedList(index);

            foreach (var item in list)
            {
                if (item.Key == key)
                    return item;
            }

            return null;
        }

        public void Remove(string key)
        {
            var index = GetIndex(key);
            
            var list = GetLinkedList(index);
            
            foreach(var item in list)
            {
                if (item.Key == key)
                    list.Remove(item);
                    break;
            }
        }

        public void Clear()
        {
            lists = new LinkedList<KeyValue>[_size];
        }

        private int GetIndex(string key)
        {
            var hash = key.GetHashCode();
            return Math.Abs(hash % lists.Length);
        }

        private LinkedList<KeyValue> GetLinkedList(int index)
        {
            if (lists[index] == null)
            {
                lists[index] = new LinkedList<KeyValue>();
                return lists[index];
            }
            else
                return lists[index];
        }
    }
}
