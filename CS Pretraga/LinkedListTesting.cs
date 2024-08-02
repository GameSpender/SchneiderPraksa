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
        static public TimeSpan Search(MyLinkedList<Podatak> list)
        {
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < list.Count; i++)
            {
                Podatak? result = list.Find(p => p.Id == i);
                if(result != null)
                {
                    result.Payload[0] = 13;
                }
            }
            sw.Stop();

            return sw.Elapsed;
        }

        static public TimeSpan Search(SimpleLinkedList list)
        {
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < list.Count; i++)
            {
                Podatak? result = list.Find(i);
                if (result != null)
                {
                    result.Payload[0] = 13;
                }
            }
            sw.Stop();

            return sw.Elapsed;
        }
    }
}
