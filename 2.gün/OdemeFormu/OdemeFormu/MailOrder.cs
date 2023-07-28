using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormu
{
    public class MailOrder : IOdemeTipi
    {
        public string OdemeYap(double tutar)
        {

            return " Mail Order ile " + tutar + " Tl Ödeme yapıldı";
        }
    }
}
