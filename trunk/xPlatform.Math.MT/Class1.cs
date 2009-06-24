using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace xPlatform.Math.MT
{
    public class MersenneTwister
    {
        protected const int NN = 312;
        protected const int MM = 156;
        protected const ulong MATRIX_A = 0xB5026F5AA96619E9uL;
        protected const ulong UM = 0xFFFFFFFF80000000uL;
        protected const ulong LM = 0x7FFFFFFFuL;
    }
}
