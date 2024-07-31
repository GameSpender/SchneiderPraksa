using CSPretraga;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Pretraga
{
    internal class Testing
    {
        static public TimeSpan SearchArrayTest(Podatak[] array, int size)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < size; i++)
            {
                Podatak? result = FindElem(array, i);
            }
            sw.Stop();
            return sw.Elapsed;
        }

        static public TimeSpan SearchListTest(List<Podatak> list)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < list.Count; i++)
            {
                Podatak? result = list.Find(p => p.Id == i);
            }
            sw.Stop();
            return sw.Elapsed;
        }

        static public TimeSpan SearchDictionaryTest(Dictionary<int, Podatak> dict)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < dict.Count; i++)
            {
                Podatak? result = dict[i];
            }
            sw.Stop();
            return sw.Elapsed;
        }

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
    }



}
