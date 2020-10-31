#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System;

namespace Baseball.ApiSharp.Dal.Tests
{
    public interface IRandomNumber
    {
        double Next();
    }

    public class LehmerRng : IRandomNumber
    {
        private const int a = 16807;
        private const int m = 2147483647;
        private const int q = 127773;
        private const int r = 2836;
        private int seed;

        public LehmerRng(int seed)
        {
            if (seed <= 0 || seed == int.MaxValue)
                throw new Exception("Bad seed");
            this.seed = seed;
        }

        public double Next()
        {
            var hi = seed / q;
            var lo = seed % q;
            seed = a * lo - r * hi;
            if (seed <= 0)
                seed = seed + m;
            return seed * 1.0 / m;
        }
    }
}
