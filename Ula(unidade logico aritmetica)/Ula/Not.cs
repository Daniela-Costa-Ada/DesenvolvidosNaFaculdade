using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ula
{
    class Not
    {
        bool pNot;

        public Not()
        {

        }

        public bool PNotGetSet
        {
            get
            {
                return pNot;
            }

            set
            {
                pNot = value;
            }
        }


        public bool Negacao(bool p_Not)
        {
            PNotGetSet = p_Not;
            return !PNotGetSet;
        }
    }
}
