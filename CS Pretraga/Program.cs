
using CS_Pretraga;
using CSPretraga;
using System.Diagnostics;

namespace CSPretraga
{
    // Schneider Praksa zadatak
    // Merenje brzine pretrage raznih struktura podataka
    internal class Program
    {
        static int elemNum;
        static Podatak[]? array;
        static List<Podatak>? list;
        static Dictionary<int, Podatak>? dict;

        static TimeSpan result;

        static void Main(string[] args)
        {
            elemNum = 2;
            for (int i = 0; i < 16; i++)
            {
                array = new Podatak[elemNum];
                list = new List<Podatak>();
                dict = new Dictionary<int, Podatak>();
                GenerateData();

                Console.WriteLine($"Testiranje pretrage struktura podataka dužine {elemNum}");

                result = Testing.SearchArrayTest(array, elemNum);
                Console.WriteLine($"Podatak[] -- Ukupno vreme je {result.TotalMilliseconds} ms");

                result = Testing.SearchListTest(list);
                Console.WriteLine($"List<Podatak> -- Ukupno vreme je {result.TotalMilliseconds} ms");

                result = Testing.SearchDictionaryTest(dict);
                Console.WriteLine($"Dictionary<int, Podatak> -- Ukupno vreme je {result.TotalMilliseconds} ms");
                Console.WriteLine();

                elemNum *= 2;
            }
        }

        // Pomoćna funkcija za inicijalizaciju svih podataka
        static void GenerateData()
        {
            if (array == null || list == null || dict == null)
            {
                return;
            }
            for (int i = 0; i < elemNum; i++)
            {
                array[i] = new Podatak(i);
                list.Add(new Podatak(i));
                dict.Add(i, new Podatak(i));
            }
        }




    }
}

