using System;
using System.Collections.Generic;

namespace E
{
    public interface IQueue<T>
    {
        void Enqueue(T item);
        T Dequeue();
        T Peek();
    }
    public class SimpleQueue<T> : IQueue<T>
    {
        private Queue<T> q = new Queue<T>();
        public void Enqueue(T item)
        {
            q.Enqueue(item);
        }
        public T Dequeue()
        {
            if (q.Count == 0)
            {
                throw new InvalidOperationException("Ничего не найдено.");
            }
            return q.Dequeue();
        }
        public T Peek()
        {
            if (q.Count == 0)
            {
                throw new InvalidOperationException("Ничего не найдено.");
            }
            return q.Peek();
        }
        public bool IsEmpty()
        {
            return q.Count == 0;
        }
        public void PrintQueue()
        {
            if (q.Count == 0)
            {
                Console.WriteLine("Ничего не найдено.");
            }
            else
            {
                foreach (T item in q)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
    public class QueueManager<T>
    {
        private SimpleQueue<T> q = new SimpleQueue<T>();
        public void AddToQueue(T item)
        {
            q.Enqueue(item);
            Console.WriteLine($"Добавлен элемент: {item}");
        }
        public void ProcessQueue()
        {
            try
            {
                T item = q.Dequeue();
                Console.WriteLine($"Обработан следующий элемент: {item}");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void ViewQueue()
        {
            q.PrintQueue();
        }
        public void CheckIfEmpty()
        {
            if (q.IsEmpty())
            {
                Console.WriteLine("Результат поиска: Ничего не найдено.");
            }
            else
            {
                Console.WriteLine("Очередь:");
            }
        }
        public void PrintSeparator()
        {
            Console.WriteLine(" ");
        }
    }

    class WO
    {
        static void Main(string[] args)
        {
            QueueManager<string> m = new QueueManager<string>();
            m.AddToQueue("Цель");
            m.AddToQueue("Труд");
            m.AddToQueue("Прогресс");

            m.PrintSeparator();
            m.CheckIfEmpty();
            m.ViewQueue();
            m.PrintSeparator();

            m.ProcessQueue();
            m.ProcessQueue();
            m.ProcessQueue();

            m.PrintSeparator();
            m.CheckIfEmpty();
        }
    }
}