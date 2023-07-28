using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormu
{
    public class KrediKarti : IOdemeTipi
    {
        public string OdemeYap(double tutar)
        {
           return " Kredi Kartı ile "+tutar + " Tl Ödeme yapıldı";
        }
    }
}
