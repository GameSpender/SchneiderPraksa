

using System.Collections.Specialized;
using System.Reflection.Metadata.Ecma335;

namespace CSMultithreading
{
    internal class MailboxProgram
    {
        private static TimeSpan producerSleep = TimeSpan.FromMilliseconds(500);

        internal static Mailbox<long> mailbox = new Mailbox<long>();

        internal const int maxFactorial = 18;
        internal static Random rand = new Random();

        static CancellationTokenSource tokenSource = new CancellationTokenSource();


        static void Main(string[] args)
        {
            Console.WriteLine("Multithreading app");
            Thread producer = new Thread(() => Producer(tokenSource.Token));
            Thread consumer = new Thread(() => Consumer(tokenSource.Token));

            producer.Start();
            consumer.Start();

            Console.ReadLine();
            tokenSource.Cancel();
            return;

        }

        static void Consumer(CancellationToken cancelToken)
        {
            long item, result;
            while (true)
            {
                if (cancelToken.IsCancellationRequested)
                {
                    Console.WriteLine("Consumer stopping...");
                    return;
                }
                item = mailbox.Get();
                result = 1;
                for (int i = 2; i <= item; i++)
                {
                    result *= i;
                }
                Console.WriteLine("Item: {0}, Factorial: {1}", item, result);
            }
        }
        static void Producer(CancellationToken cancelToken)
        {
            long item;
            while (true)
            {
                if (cancelToken.IsCancellationRequested)
                {
                    Console.WriteLine("Producer stopping...");
                    return;
                }

                item = rand.Next(maxFactorial);
                //Console.WriteLine("Adding item: {0}", item);
                mailbox.Add(item);
                
                Thread.Sleep(producerSleep);
            }
        }
    }

}
