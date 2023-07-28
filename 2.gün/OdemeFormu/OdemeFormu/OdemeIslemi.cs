using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormu
{
    public class OdemeIslemi
    {
        public IOdemeTipi iOdemeTipi;

        public OdemeIslemi(IOdemeTipi iOdemeTipi)
        {
            this.iOdemeTipi = iOdemeTipi;
        }

        public string Ode(double tutar)
        {
            return iOdemeTipi.OdemeYap(tutar);
        }

    }
}
