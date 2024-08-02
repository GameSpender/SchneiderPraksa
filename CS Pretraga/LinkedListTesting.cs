using CSPretraga;
using CSPretraga.Strukture;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPretraga
{
    internal class LinkedListTesting
    {
        /// <summary>
        /// Traži sve elemente liste
        /// Modifikuje payload[0] podatka da bude 30
        /// </summary>
        /// <param name="list"></param>
        /// <returns>Vreme pretrage svih podataka</returns>
        static public TimeSpan Search(MyLinkedList<Podatak> list)
        {
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < list.Count; i++)
            {
                Podatak? result = list.Find(p => p.Id == i);
                if(result != null)
                {
                    result.Payload[0] = 30;
                }
            }
            sw.Stop();

            return sw.Elapsed;
        }

        /// <summary>
        /// Traži sve elemente liste
        /// Modifikuje payload[0] podatka da bude 31
        /// </summary>
        /// <param name="list"></param>
        /// <returns>Vreme pretrage svih podataka</returns>
        static public TimeSpan Search(SimpleLinkedList list)
        {
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < list.Count; i++)
            {
                Podatak? result = list.Find(i);
                if (result != null)
                {
                    result.Payload[0] = 31;
                }
            }
            sw.Stop();

            return sw.Elapsed;
        }
    }
}
