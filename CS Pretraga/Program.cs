
using CS_Pretraga;
using CSPretraga;
using System.Diagnostics;

namespace CSPretraga
{
    internal class Program
    {
        const int elemNum = 10000;
        static Podatak[] array = new Podatak[elemNum];
        static List<Podatak> list = new List<Podatak>();
        static Dictionary<int, Podatak> dict = new Dictionary<int, Podatak>();

        /// <summary>
        /// U ovaj niz ćemo stavljati nađene elemente kod svakog algoritma
        /// </summary>

        static Stopwatch sw = new Stopwatch();

        static void Main(string[] args)
        {
            Console.WriteLine("Pretraga niza");
            Popuni();

            TimeSpan result = Testing.SearchArrayTest(array, elemNum);
            Console.WriteLine($"Podatak[] -- Ukupno vreme je {result.TotalMilliseconds} ms");

            result = Testing.SearchListTest(list);
            Console.WriteLine($"List<Podatak> -- Ukupno vreme je {result.TotalMilliseconds} ms");

            result = Testing.SearchDictionaryTest(dict);
            Console.WriteLine($"Dictionary<int, Podatak> -- Ukupno vreme je {result.TotalMilliseconds} ms");

            
        }

        static void Popuni()
        {
            for (int i = 0; i < elemNum; i++)
            {
                array[i] = new Podatak(i);
                list.Add(new Podatak(i));
                dict.Add(i, new Podatak(i));
            }
        }




    }
}

