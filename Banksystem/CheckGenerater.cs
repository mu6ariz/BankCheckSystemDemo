using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banksystem
{
    class CheckGenerater
    {
        

        static Generator k;
        static Generator kc;
        static Generator c;
        static CheckGenerater()
        {
            k = new Generator();
            kc = new Generator();
            c = new Generator();
        }

        public string kGenerate()
        {
            return $"K{k.GenerateNumber()}";
        }

        public string eGenerate()
        {
            return $"EM{kc.GenerateNumber()}";
        }


        public string cGenerate()
        {
            return $"C{c.GenerateNumber()}";
        }

    }
}
