using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMultithreading
{
    internal class Mailbox<T>
    {
        private Queue<T> queue;
        Mutex mutex;

        public Mailbox()
        {
            queue = new Queue<T>();
            mutex = new Mutex();
        }

        /// <summary>
        /// Adds item into the mailbox
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            mutex.WaitOne();
            queue.Enqueue(item);
            mutex.ReleaseMutex();
        }

        /// <summary>
        /// Tries to get an item from the mailbox
        /// </summary>
        /// <param name="item">Reference to the item</param>
        /// <returns>True if succesfull, false if mailbox is empty</returns>
        public bool TryGet(out T? item)
        {
            item = default;
            mutex.WaitOne();
            if (queue.Count == 0) { return false; }
            item = queue.Dequeue();
            mutex.ReleaseMutex();
            return true;
        }

    }
}
