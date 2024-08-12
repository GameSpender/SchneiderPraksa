

namespace CSMultithreading
{
    internal class Program
    {
        private static TimeSpan producerSleep = TimeSpan.FromMilliseconds(500);

        internal static Mailbox<int> mailbox = new Mailbox<int>();

        internal const int maxFactorial = 12;
        internal static Random rand = new Random();


        static void Main(string[] args)
        {
            Console.WriteLine("Multithreading app");

        }

        void Consumer()
        {
            int item;
            while (true)
            {
                if (mailbox.TryGet(out item) == true)
                {
                    for (int i = 0; i < item; i++)
                    {

                    }
                }
            }
        }
        static void Producer()
        {
            while (true)
            {
                mailbox.Add(rand.Next(maxFactorial));
                Thread.Sleep(producerSleep);
            }
        }
    }

}
