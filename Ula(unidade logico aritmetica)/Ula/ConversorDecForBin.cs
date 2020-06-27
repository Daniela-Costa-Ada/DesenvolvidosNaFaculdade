using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ula
{
    class ConversorDecForBin
    {
        int num;
        int aux;
        int baseDaConv;
        int lenthTamBit;
        int[] bin = new int[8];

        public int NumGetESet
        {
            get
            {
                return num;
            }

            set
            {
                num = value;
            }
        }

        public int AuxGetESet
        {
            get
            {
                return aux;
            }

            set
            {
                aux = value;
            }
        }

        public int BaseDaConvGetESet
        {
            get
            {
                return baseDaConv;
            }

            set
            {
                baseDaConv = value;
            }
        }

        public int LenthTamBitGetESet
        {
            get
            {
                return lenthTamBit;
            }

            set
            {
                lenthTamBit = value;
            }
        }

        public int[] BinGetESet
        {
            get
            {
                return bin;
            }

            set
            {
                bin = value;
            }
        }

        public ConversorDecForBin(int num_Conv, int baseDaConv_p, int lenthTamBit_p)
        {
            NumGetESet = num_Conv;
            BaseDaConvGetESet = baseDaConv_p;
            LenthTamBitGetESet = lenthTamBit_p;
        }
        public int[] ConverteDB()
        {
            for (AuxGetESet = LenthTamBitGetESet - 1; AuxGetESet >= 0; AuxGetESet--)
            {
                BinGetESet[AuxGetESet] = NumGetESet % BaseDaConvGetESet;
                NumGetESet = NumGetESet / BaseDaConvGetESet;
            }
            return BinGetESet;
        }
    }
}

