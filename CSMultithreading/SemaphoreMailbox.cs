using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSMultithreading
{
    internal class SemaphoreMailbox<T>
    {
        private Queue<T> queue;
        private Semaphore semaphore;
        private CancellationToken cancellationToken;

        public SemaphoreMailbox(CancellationToken token)
        {
            queue = new Queue<T>();
            semaphore = new Semaphore (0, 1);
            cancellationToken = token;
        }
        public void Add(T item)
        {
            semaphore.WaitOne();
            Console.WriteLine("Semaphore queue write: {0}", item);
            queue.Enqueue(item);
            semaphore.Release();
        }

        public T Get()
        {
            semaphore.WaitOne();
            T retval = queue.Dequeue();
            Console.WriteLine("Semaphore queue read: {0}", retval);
            semaphore.Release();
            return retval;
        }
    }
}
