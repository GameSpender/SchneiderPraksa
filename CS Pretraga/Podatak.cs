using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPretraga
{

    // Proizvoljni podatak koji sadrži ID i 15 integer polja
    /// <summary>
    /// Generic podatak
    /// </summary>
    internal class Podatak
    {
        public int Id;
        public int[] Payload;

        public Podatak(int id)
        {
            Id = id;
            Payload = new int[15];
        }
    }
}