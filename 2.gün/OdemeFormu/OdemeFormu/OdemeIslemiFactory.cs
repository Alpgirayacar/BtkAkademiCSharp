using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace OdemeFormu
{
    public class OdemeIslemiFactory
    {

        public IOdemeTipi GetInstance(string className)
        {
            //KrediKarti k = new KrediKarti();
            var newClass = Assembly.GetAssembly(typeof(IOdemeTipi)).CreateInstance("OdemeFormu." + className);

            return (IOdemeTipi)newClass;
        }
    }
}
