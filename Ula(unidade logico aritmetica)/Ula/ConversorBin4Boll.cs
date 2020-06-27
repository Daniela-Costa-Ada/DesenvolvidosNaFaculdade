using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ula
{
    class ConversorBin4Boll
    {
        int[] vet1 = new int[8];
        bool[] vet2 = new bool[8];
        int cont;

        public int[] Vet1GetESet
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

        public bool[] Vet2GetESet
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

        public ConversorBin4Boll(int[] vet_1)
        {
            Vet1GetESet = vet_1;
        }
        public bool[] CoverteBinToBoll()
        {
            for (ContGetESet = 0; ContGetESet < 8; ContGetESet++)
            {
                if (Vet1GetESet[ContGetESet] == 0)
                {
                    Vet2GetESet[ContGetESet] = false;
                }
                else
                    Vet2GetESet[ContGetESet] = true;
            }
            return Vet2GetESet;
        }
    }
}
