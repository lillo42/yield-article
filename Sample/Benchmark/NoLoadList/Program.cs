using System;
using System.Collections.Generic;
using System.Threading;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace NoLoadList
{
    public class Program
    {
        const int MAX = 1_00_000;
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Program>();
        }

        [Benchmark]
        public static void NoYield()
        {
            foreach(var item in GetNoYieldPower(2, MAX))
            {
                int i = item + 1;
            }
        }

        public static IEnumerable<int> GetNoYieldPower(int number, int expoent)
        {
            var ret = new List<int>();
            int counter = 0;
            int result = 1;
            while (counter++ < expoent)
            {
                result *= number;
                ret.Add(result);
            }

            return ret;
        }

        [Benchmark]
        public static void Yield()
        {
            foreach (var item in GetYieldPower(2, MAX))
            {
                int i = item + 1;
            }
        }

        public static IEnumerable<int> GetYieldPower(int number, int expoent)
        {
            int counter = 0;
            int result = 1;
            while (counter++ < expoent)
            {
                result *= number;
                yield return result;
            }

        }

    }
}
