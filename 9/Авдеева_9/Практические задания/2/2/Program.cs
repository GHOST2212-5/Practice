using System;
using System.Collections.Generic;

namespace E
{
    public class MyDictionary<TKey, TValue>
    {
        private List<KeyValuePair<TKey, TValue>>[] a;
        private int s;

        public MyDictionary(int c = 16)
        {
            s = c;
            a = new List<KeyValuePair<TKey, TValue>>[s];
        }
        public void Add(TKey key, TValue value)
        {
            int x = GetBucketIndex(key);
            if (a[x] == null)
            {
                a[x] = new List<KeyValuePair<TKey, TValue>>();
            }

            foreach (var p in a[x])
            {
                if (EqualityComparer<TKey>.Default.Equals(p.Key, key))
                {
                    throw new ArgumentException("Ключ уже существует.");
                }
            }

            a[x].Add(new KeyValuePair<TKey, TValue>(key, value));
        }
        public bool Remove(TKey key)
        {
            int x = GetBucketIndex(key);
            if (a[x] == null) return false;

            for (int i = 0; i < a[x].Count; i++)
            {
                if (EqualityComparer<TKey>.Default.Equals(a[x][i].Key, key))
                {
                    a[x].RemoveAt(i);
                    return true;
                }
            }

            return false;
        }
        public TValue Find(TKey key)
        {
            int x = GetBucketIndex(key);
            if (a[x] != null)
            {
                foreach (var p in a[x])
                {
                    if (EqualityComparer<TKey>.Default.Equals(p.Key, key))
                    {
                        return p.Value;
                    }
                }
            }

            throw new KeyNotFoundException("Проверка: Элемент не найден.");
        }
        private int GetBucketIndex(TKey key)
        {
            return Math.Abs(key.GetHashCode()) % s;
        }
    }
    public class DictionaryManager<TKey, TValue>
    {
        private MyDictionary<TKey, TValue> myDictionary = new MyDictionary<TKey, TValue>();

        public void AddItem(TKey key, TValue value)
        {
            try
            {
                myDictionary.Add(key, value);
                Console.WriteLine($"Добавлен элемент: {key}. {value}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"{e.Message}");
            }
        }
        public void RemoveItem(TKey key)
        {
            if (myDictionary.Remove(key))
            {
                Console.Write($"Элемент с ключом {key} удалён.");
            }
            else
            {
                Console.Write($"Эл-т с ключом {key} не найден.");
            }
        }
        public void FindItem(TKey key)
        {
            try
            {
                TValue value = myDictionary.Find(key);
                Console.Write($"Выбран элемент: {key}. {value}");
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine($"{e.Message}");
            }
        }
    }

    class MD
    {
        static void Main()
        {
            DictionaryManager<int, string> m = new DictionaryManager<int, string>();
            m.AddItem(1, "Программа");
            m.AddItem(2, "Время");
            m.AddItem(3, "Код");
            Console.WriteLine();

            m.FindItem(2);
            Console.WriteLine();
            m.RemoveItem(2);
            Console.WriteLine();
            m.FindItem(2);
        }
    }
}
