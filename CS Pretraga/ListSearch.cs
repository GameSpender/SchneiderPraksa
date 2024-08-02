using CSPretraga;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPretraga
{
    internal class ListSearch
    {
        /// <summary>
        /// Traži sve elemente liste koristeći <see cref="List{T}.Find(Predicate{T})"/>
        /// <br/>
        /// Modifikuje payload[0] podatka da bude 20
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        static public TimeSpan Search(List<Podatak> list)
        {
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < list.Count; i++)
            {
                Podatak? rez = list.Find(p => p.Id == i);
                if(rez != null) rez.Payload[0] = 20;
            }
            sw.Stop();

            return sw.Elapsed;
        }


        /// <summary>
        /// Traži sve elemente liste koristeći for petlju
        /// <br/>
        /// Modifikuje payload[0] podatka da bude 21
        /// </summary>
        /// <param name="list">Lista</param>
        /// <returns>Vreme pretrage svih podataka</returns>
        static public TimeSpan SearchFor(List<Podatak> list)
        {
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j].Id == i)
                    {
                        list[j].Payload[0] = 21;
                        break;
                    }
                }
            }
            sw.Stop();

            return sw.Elapsed;
        }

        /// <summary>
        /// Traži sve elemente liste koristeći foreach petlju
        /// <br/>
        /// Modifikuje payload[0] podatka da bude 22
        /// </summary>
        /// <param name="list">Lista</param>
        /// <returns>Vreme pretrage svih podataka</returns>
        static public TimeSpan SearchForeach(List<Podatak> list)
        {
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < list.Count; i++)
            {
                foreach (Podatak pod in list)
                {
                    if (pod.Id == i)
                    {
                        pod.Payload[0] = 22;
                        break;
                    }
                }
            }
            sw.Stop();

            return sw.Elapsed;
        }
    }
}
