using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributaBtkOrnek
{
    public class Ogrenci
    {
        [ZorunluAlan]
        public string Adi;
        [ZorunluAlan]
        public string Soyadi;
        [ZorunluAlan]
        public string Bolum;
    }
}
