using System;
using System.Collections.Generic;
using static System.Console;

namespace TryCatch 
{
    class Program 
    {
        // This won't compile, because I want to show yield can't be used on try-catch-finally
        static void Main (string[] args) 
        {
            foreach (int result in ErrorReturn (2, 8))
                Write ($"{result} \t");
            WriteLine (string.Empty);
            WriteLine ("Finish...");
            ReadLine ();
        }

        private static IEnumerable<int> ErrorTryCatchFinallyReturn (int number, int expoent) 
        {
            int counter = 0;
            int result = 1;
            try 
            {
                while (counter++ < expoent) 
                {
                    result *= number;
                    yield return result;
                }
            } 
            catch 
            {
                yield return 1;
            }
            finally
            {
                yield return 1;
            }
        }

        private static IEnumerable<int> ErrorTryFinallyReturn (int number, int expoent) 
        {
            int counter = 0;
            int result = 1;
            try 
            {
                while (counter++ < expoent) 
                {
                    result *= number;
                    yield return result;
                }
            } 
            finally
            {
                yield return 1;
            }
        }


        private static IEnumerable<int> ErrorBrek (int number, int expoent) 
        {
            int counter = 0;
            int result = 1;
            try 
            {
                while (counter++ < expoent) 
                {
                    result *= number;
                    yield break;
                }
            } 
            catch 
            {
                yield break;
            }
            finally
            {
                yield break;
            }
        }
    }
}