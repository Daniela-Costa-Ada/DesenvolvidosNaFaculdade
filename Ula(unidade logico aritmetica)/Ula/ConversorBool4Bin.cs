using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ula
{
    class ConversorBool4Bin
    {

        bool[] vet1 = new bool[8];
        int[] vet2 = new int[8];
        int cont;
        public ConversorBool4Bin(bool[] vet_1)
        {
            Vet1GetESet = vet_1;
        }
        public bool[] Vet1GetESet
        {
            get
            {
                return vet1;
            }

            set
            {
                vet1 = value;
            }
        }

        public int[] Vet2GetESet
        {
            get
            {
                return vet2;
            }

            set
            {
                vet2 = value;
            }
        }

        public int ContGetESet
        {
            get
            {
                return cont;
            }

            set
            {
                cont = value;
            }
        }

        public int[] CoverteBool4Bin()
        {
            for (ContGetESet = 0; ContGetESet < 8; ContGetESet++)
            {
                if (Vet1GetESet[ContGetESet] == false)
                {
                    Vet2GetESet[ContGetESet] = 0;
                }
                else
                    Vet2GetESet[ContGetESet] = 1;
            }
            return Vet2GetESet;

        }
    }
}
