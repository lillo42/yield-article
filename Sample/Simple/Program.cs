using System.Collections.Generic;
using static System.Console;

namespace Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(int result in Power(2, 8))
                Write($"{result} \t");
            WriteLine(string.Empty);
            WriteLine("Finish...");
            ReadLine();
        }

        private static IEnumerable<int> Power(int number, int expoent)
        {
            int counter = 0;
            int result = 1;
            while(counter++ < expoent)
            {
                result *= number;
                yield return result;
            }
        }
    }
}
