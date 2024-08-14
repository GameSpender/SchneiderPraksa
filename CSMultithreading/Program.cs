using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMultithreading
{
    internal class Program
    {
        private static TimeSpan producerSleep = TimeSpan.FromMilliseconds(500);

        static BlockingCollection<long> blocks = new BlockingCollection<long>();
        internal const int maxFactorial = 18;
        internal static Random rand = new Random();

        static CancellationTokenSource tokenSource = new CancellationTokenSource();
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Task prod = Task.Run(() => Producer(tokenSource.Token));
            Task cons = Task.Run(() => Consumer(tokenSource.Token));
            Task consExtra = Task.Run(() => ConsumerException(tokenSource.Token), tokenSource.Token);

            Console.ReadLine();
            tokenSource.Cancel();

            try
            {
                await prod;
                await cons;
                await consExtra;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Task exception: {0}", ex);
            }

            tokenSource.Dispose();
            return;
        }
        /// <summary>
        /// Vadi i računa faktorijel vrednosti sa <see cref="blocks">blocks</see>
        /// </summary>
        /// <param name="token"></param>
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

                try
                {
                    item = blocks.Take(cancelToken);
                }
                catch (OperationCanceledException)
                {
                    Console.WriteLine("Consumer stopped during Take...");
                    return;
                }
                

                result = 1;
                for (int i = 2; i <= item; i++)
                {
                    result *= i;
                }
                Console.WriteLine("Item: {0}, Factorial: {1}", item, result);
            }
        }

        /// <summary>
        /// Vadi i računa faktorijel vrednosti sa <see cref="blocks">blocks</see>
        /// </summary>
        /// <remarks>Baci exception kada je prekinut pomoću <paramref name="token"/></remarks>
        /// <param name="token"></param>
        /// <exception cref="OperationCanceledException"/>
        static void ConsumerException(CancellationToken token)
        {
            long item, result;
            while (true)
            {
                item = blocks.Take(token);

                result = 1;
                for (int i = 2; i <= item; i++)
                {
                    result *= i;
                }
                Console.WriteLine("No Cancel Item: {0}, Factorial: {1}", item, result);
            }
        }


        /// <summary>
        /// Dodaje nasumičan broj manji od <see cref="maxFactorial">maxFactorial</see> u <see cref="blocks">blocks</see>
        /// </summary>
        /// <param name="cancelToken"></param>
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
                Console.WriteLine("Adding item: {0}", item);
                try
                {
                    blocks.Add(item, cancelToken);
                }
                catch (OperationCanceledException)
                {
                    Console.WriteLine("Producer stopped during Add...");
                    return;
                }
                

                Thread.Sleep(producerSleep);
            }
        }

    }
}
