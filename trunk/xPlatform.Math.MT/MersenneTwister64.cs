using System;

namespace xPlatform.Math.MT
{
    // MersenneTwister 64bit version
    // Author: Takuji Nishimura, Makoto Matsumoto
    // (c) 1997 ~ 2002, Makoto Matsumoto and Takuji Nishimura
    // http://www.math.sci.hiroshima-u.ac.jp/~m-mat/MT/emt.html
    // C# version (c) 2009, rkttu.com
    public class MersenneTwister64
    {
        protected const int NN = 312;
        protected const int MM = 156;

        [CLSCompliant(false)]
        protected const ulong MATRIX_A = 0xB5026F5AA96619E9uL;

        [CLSCompliant(false)]
        protected const ulong UM = 0xFFFFFFFF80000000uL;

        [CLSCompliant(false)]
        protected const ulong LM = 0x7FFFFFFFuL;

        private ulong[] mag01 = new ulong[] { 0uL, MATRIX_A };
        private ulong[] mt = new ulong[NN];
        private int mti = NN + 1;

        private void InternalInitialize(ulong seed)
        {
            this.mt[0] = seed;

            for (this.mti = 1; this.mti < NN; this.mti++)
                this.mt[this.mti] = (6364136223846793005uL * (this.mt[this.mti - 1] ^ (this.mt[this.mti - 1] >> 62)) + (ulong)this.mti);
        }

        public MersenneTwister64()
            : this((ulong)DateTime.Now.Ticks)
        {
        }

        [CLSCompliant(false)]
        public MersenneTwister64(ulong seed)
            : base()
        {
            this.InternalInitialize(seed);
        }

        [CLSCompliant(false)]
        public MersenneTwister64(ulong[] init_key, ulong key_length)
            : this(19650218uL)
        {
            ulong i, j, k;
            i = 1uL; j = 0uL;
            k = (NN > key_length ? NN : key_length);

            for (; k != 0; k--)
            {
                // non-linear
                this.mt[i] = (this.mt[i] ^ ((this.mt[i - 1] ^ (this.mt[i - 1] >> 62)) * 3935559000370003845uL)) + init_key[j] + j;
                i++; j++;
                
                if (i >= NN)
                {
                    this.mt[0] = this.mt[NN - 1];
                    i = 1uL;
                }

                if (j >= key_length)
                    j = 0uL;
            }

            for (k = unchecked(NN - (1uL)); k != 0; k--)
            {
                // non-linear
                this.mt[i] = (this.mt[i] ^ ((this.mt[i - 1] ^ (this.mt[i - 1] >> 62)) * 2862933555777941757uL)) - i;
                i++;

                if (i >= NN)
                {
                    this.mt[0] = this.mt[NN - 1];
                    i = 1;
                }
            }

            this.mt[0] = 1uL << 63;
        }

        [CLSCompliant(false)]
        public ulong NextUInt64()
        {
            int i = 0;
            ulong x = 0uL;

            if (this.mti >= NN)
            {
                if (this.mti == NN + 1)
                    this.InternalInitialize(5489uL);

                for (i = 0; i < NN - MM; i++)
                {
                    x = (this.mt[i] & UM) | (this.mt[i + 1] & LM);
                    this.mt[i] = this.mt[i + MM] ^ (x >> 1) ^ this.mag01[(int)(x & 1uL)];
                }

                for (; i < NN - 1; i++)
                {
                    x = (this.mt[i] & UM) | (this.mt[i + 1] & LM);
                    this.mt[i] = this.mt[i + (MM - NN)] ^ (x >> 1) ^ this.mag01[(int)(x & 1uL)];
                }

                x = (this.mt[NN - 1] & UM) | (this.mt[0] & LM);
                this.mt[NN - 1] = this.mt[MM - 1] ^ (x >> 1) ^ this.mag01[(int)(x & 1uL)];
                this.mti = 0;
            }

            x = this.mt[this.mti++];
            x ^= (x >> 29) & 0x5555555555555555uL;
            x ^= (x << 17) & 0x71D67FFFEDA60000uL;
            x ^= (x << 37) & 0xFFF7EEE000000000uL;
            x ^= (x >> 43);
            return x;
        }

        public long NextInt64()
        {
            return (long)(NextUInt64() >> 11);
        }

        public DateTime NextDateTime()
        {
            return new DateTime(this.NextInt64());
        }

        public double NextDoubleClosedRealInterval()
        {
            return (this.NextUInt64() >> 11) * (1.0 / 9007199254740991.0);
        }

        public double NextDoubleHalfOpenedRealInterval()
        {
            return (this.NextUInt64() >> 11) * (1.0 / 9007199254740992.0);
        }

        public double NextDoubleOpenedRealInterval()
        {
            return ((this.NextUInt64() >> 12) + 0.5) * (1.0 / 4503599627370496.0);
        }
    }
}
