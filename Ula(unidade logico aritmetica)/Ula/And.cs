using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ula
{
    public class And
    {

        bool pAnd;
        bool qAnd;

        public And()
        {
        }

        public bool PAndGetSet
        {
            get
            {
                return pAnd;
            }

            set
            {
                pAnd = value;
            }
        }


        public bool QAndGetSet
        {
            get
            {
                return qAnd;
            }

            set
            {
                qAnd = value;
            }
        }



        public bool Conjunção(bool p_And, bool q_And)
        {
            PAndGetSet = p_And;
            QAndGetSet = q_And;

            return PAndGetSet && QAndGetSet;
        }
    }
}
