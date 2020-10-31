#region Copyright & OSS License
// Copyright Information
// All source is copyright, Kevin Wittmer
// See License.txt for more information (check Visual Studio Solution Items)
// ==================================
#endregion

using System;

namespace Baseball.ApiSharp.Dal.Tests
{
    public class RandomNumberHelper
    {
        private static readonly Random Random = new Random(DateTime.Now.Millisecond);

        public static int NextInteger()
        {
            return Random.Next();
        }

        public static int NextIntegerInRange(int lowBound, int highBound)
        {
            return Random.Next(lowBound, highBound);
        }
    }

    public class CustomRandomNumberHelper
    {
        private static readonly IRandomNumber Random = new LehmerRng(DateTime.Now.Millisecond);

        public static int NextInteger()
        {
            return (int)Random.Next();
        }
    }
}
