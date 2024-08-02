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
        /// <summary>
        /// Traži sve elemente niza
        /// Modifikuje payload[0] podatka da bude 10
        /// </summary>
        /// <param name="array">niz</param>
        /// <param name="size">veličina niza</param>
        /// <returns>Vreme pretrage svih podataka</returns>
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
        /// <summary>
        /// Helper
        /// Traži Podatak sa datom ID vrednošču
        /// </summary>
        /// <param name="niz">niz za pretragu</param>
        /// <param name="id">ID vrednost</param>
        /// <returns>Podatak odgovarajuće ID vrednosti ili null ako ne postoji</returns>
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
        /// <summary>
        /// DEPRECATED - koristiti <see cref="LinkedListTesting.Search()"/>
        /// Traži sve elemente Liste
        /// Modifikuje payload[0] podatka da bude 11
        /// </summary>
        /// <param name="list"></param>
        /// <returns>Vreme pretrage svih podataka</returns>
        static public TimeSpan SearchListTest(List<Podatak> list)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < list.Count; i++)
            {
                Podatak? result = list.Find(p => p.Id == i);
                if (result != null)
                    result.Payload[0] = 11;
            }
            sw.Stop();
            return sw.Elapsed;
        }

        // Test funkcija koja traži svaki element u rečniku
        /// <summary>
        /// Traži sve elemente u rečniku
        /// Modifikuje Payload[0] Podatka da bude 12
        /// </summary>
        /// <param name="dict"></param>
        /// <returns>Vreme pretrage svih podataka</returns>
        static public TimeSpan SearchDictionaryTest(Dictionary<int, Podatak> dict)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < dict.Count; i++)
            {
                Podatak? result = dict[i];
                if (result != null)
                    result.Payload[0] = 12;
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
