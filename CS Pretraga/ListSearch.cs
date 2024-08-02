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
        /// Pretraga liste koristeći List.Find() i Linq
        /// </summary>
        /// <param name="list">Lista</param>
        /// <returns>Vreme pretrage svih podataka</returns
        static public TimeSpan Search(List<Podatak> list)
        {
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < list.Count; i++)
            {
                Podatak? rez = list.Find(p => p.Id == i);
                rez.Payload[0] = 13;
            }
            sw.Stop();

            return sw.Elapsed;
        }


        /// <summary>
        /// Pretraga liste koristeći for petlju
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
                        list[j].Payload[0] = 13;
                        break;
                    }
                }
            }
            sw.Stop();

            return sw.Elapsed;
        }

        /// <summary>
        /// Pretraga liste koristeći foreach petlju
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
                        pod.Payload[0] = 13;
                        break;
                    }
                }
            }
            sw.Stop();

            return sw.Elapsed;
        }
    }
}
