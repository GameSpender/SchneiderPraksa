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

        public Mailbox()
        {
            queue = new Queue<T>();
        }

        /// <summary>
        /// Adds item into the mailbox
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            lock (queue)
            {
                Console.WriteLine("Writing to queue, item: {0}", item);
                queue.Enqueue(item);
                Monitor.Pulse(queue);
            }
        }

        /// <summary>
        /// Tries to get an item from the mailbox
        /// </summary>
        /// <param name="item">Reference    to the item</param>
        /// <returns>True if succesfull, false if mailbox is empty</returns>
        public bool TryGet(out T? item)
        {
            item = default;
            if (queue.Count == 0) { return false; }
            lock (queue)
            { 
                
                item = queue.Dequeue();
                Console.WriteLine("Reading from queue {0}", item);
            }
            return true;
        }

        /// <summary>
        /// <c>Blocking</c> 
        /// <para>Gets a <typeparamref name="T"/> item from the mailbox</para>
        /// </summary>
        /// <returns>item from mailbox</returns>
        public T Get()
        {
            lock (queue)
            {
                if(queue.Count == 0)
                {
                    Monitor.Wait(queue);
                }
                return queue.Dequeue();
            }
        }
    }
}
