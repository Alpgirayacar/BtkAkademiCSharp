using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormu
{
    public class SmsOdeme : IOdemeTipi
    {
        public string OdemeYap(double tutar)
        {
            return " Sms ile " + tutar + " Tl Ödeme yapıldı";
        }
    }
}
