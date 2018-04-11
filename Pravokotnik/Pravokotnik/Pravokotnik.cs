using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pravokotnik
{
    class Pravokotnik
    {
        public Pravokotnik()
        {
            Širina = 0;
            Višina = 0;
        }

        public Pravokotnik(int širina, int višina)
        {
            Širina = širina;
            Višina = višina;
        }
        public int Širina
        {
            get;
            set;
        }

        public int Višina
        {
            get;
            set;
        }
        public int Ploščina
        {
            get
            {
                return Širina * Višina;
            }
        }

        public static bool operator == (Pravokotnik a, Pravokotnik b)
        {
            return a.Ploščina == b.Ploščina;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }


}
