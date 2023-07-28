using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log
{
    public class JsonLog : IHataTuru
    {
        /*
        public IHataTuru hataYontemleti;
        public string HataIsmı(string hataYontemleti)
        {
            return "proğam" + hataYontemleti + "hatası verdi";
        }
    

        */
        IHataTuru hataTuru;
        public JsonLog(IHataTuru hataTuru) 
        {
            this.hataTuru = hataTuru;
            
        }


        public string HataIsmı(string value)
        {
            return value+"DB ye kaydedildi";
        }
    }
}

