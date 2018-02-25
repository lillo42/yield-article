using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace LoadList
{
    public  class Program
    {
        const int MAX = 1_000_000;
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Program>();
            Console.ReadLine();
        }

        [Benchmark]
        public static void NoYield()
        {
            for (int i = 0; i < MAX; i++)
            {
                int sum = 0;
                foreach (int s in GetNoYield())
                {
                    sum += s;
                }
            }
        }

        public static IEnumerable<int> GetNoYield()
        {
            return new int[] { 10, 20, 30, 40, 50 };
        }

        [Benchmark]
        public static void Yield()
        {
            for (int i = 0; i < MAX; i++)
            {
                int sum = 0;
                foreach (int s in GetYield())
                {
                    sum += s;
                }
            }
        }

        public static IEnumerable<int> GetYield()
        {
            yield return 10;
            yield return 20;
            yield return 30;
            yield return 40;
            yield return 50;
        }

    }
}