using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log
{
    public class XmlLog : IHataTuru
    {
        public string HataIsmı(string value)
        {
            return value+"hatası verildi ";   
        }
    }
}
