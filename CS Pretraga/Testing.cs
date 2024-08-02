using CSPretraga;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPretraga
{
    internal class Testing
    {
        // Test funkcija koja traži svaki element u nizu
        static public TimeSpan SearchArrayTest(Podatak[] array, int size)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < size; i++)
            {
                Podatak? result = FindElem(array, i);
                if (result != null)
                    result.Payload[0] = 10;
            }
            sw.Stop();
            return sw.Elapsed;
        }

        // Pomoćna funkcija uz SearchArrayTest za pronalazak Podatka sa datim ID-om
        static private Podatak? FindElem(Podatak[] niz, int id)
        {
            for (int i = 0; i < niz.Length; i++)
            {
                {
                    if (niz[i].Id == id)
                    {
                        return niz[i];
                    }
                }
            }
            return null;
        }

        // Test funkcija koja traži svaki element u listi
        static public TimeSpan SearchListTest(List<Podatak> list)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < list.Count; i++)
            {
                Podatak? result = list.Find(p => p.Id == i);
                if (result != null)
                    result.Payload[0] = 10;
            }
            sw.Stop();
            return sw.Elapsed;
        }

        // Test funkcija koja traži svaki element u rečniku
        /// <summary>
        /// Test funkcija koja traži svaki element u rečniku
        /// </summary>
        /// <param name="dict"></param>
        /// <returns>vreme pretrage</returns>
        static public TimeSpan SearchDictionaryTest(Dictionary<int, Podatak> dict)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < dict.Count; i++)
            {
                Podatak? result = dict[i];
                if (result != null)
                    result.Payload[0] = 10;
            }
            sw.Stop();
            return sw.Elapsed;
        }


        // sa trenutnom strukturom podataka, nije moguće koristiti LinkedList klasu pošto
        // nema predikatsku pretragu
        /*static public TimeSpan SearchLinkedList(LinkedList<Podatak> list)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i <= list.Count; i++)
            {
                
            }
            sw.Stop();
            return sw.Elapsed;
        }*/
    }
}
