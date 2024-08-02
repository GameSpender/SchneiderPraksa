
using CSPretraga;
using CSPretraga.Strukture;
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
        static MyLinkedList<Podatak>? myLinkedList;
        static LinkedList<Podatak>? linkedList;
        static SimpleLinkedList simpleLinkedList;

        static TimeSpan result;

        static void Main(string[] args)
        {
            elemNum = 512;

            Console.WriteLine("Testiranje pretraga raznih struktura");
            Console.WriteLine("Broj Podataka, Array, List, Dictionary, MyLinkedList, SimpleLinkedList, List (For loop), List (Foreach loop)");
            for (int i = 0; i < 9; i++)
            {
                array = new Podatak[elemNum];
                list = new List<Podatak>();
                dict = new Dictionary<int, Podatak>();
                myLinkedList = new MyLinkedList<Podatak>();
                linkedList = new LinkedList<Podatak>();
                simpleLinkedList = new();

                GenerateData();


                Console.Write($"{elemNum}, ");

                result = Testing.SearchArrayTest(array, elemNum);
                Console.Write($"{result.TotalMilliseconds}, ");

                result = Testing.SearchListTest(list);
                Console.Write($"{result.TotalMilliseconds}, ");

                result = Testing.SearchDictionaryTest(dict);
                Console.Write($"{result.TotalMilliseconds}, ");

                result = LinkedListTesting.Search(myLinkedList);
                Console.Write($"{result.TotalMilliseconds}, ");

                result = LinkedListTesting.Search(simpleLinkedList);
                Console.Write($"{result.TotalMilliseconds}, ");

                result = ListSearch.SearchFor(list);
                Console.Write($"{result.TotalMilliseconds}, ");

                result = ListSearch.SearchForeach(list);
                Console.Write($"{result.TotalMilliseconds}");

                Console.WriteLine();
                elemNum *= 2;
            }
        }

        // Pomoćna funkcija za inicijalizaciju svih podataka
        static void GenerateData()
        {
            if (array == null || list == null || dict == null || myLinkedList == null || linkedList == null)
            {
                return;
            }
            for (int i = 0; i < elemNum; i++)
            {
                array[i] = new Podatak(i);
                list.Add(new Podatak(i));
                dict.Add(i, new Podatak(i));
                myLinkedList.Add(new Podatak(i));
                linkedList.AddLast(new Podatak(i));
                simpleLinkedList.Add(new Podatak(i));
            }
        }




    }
}

