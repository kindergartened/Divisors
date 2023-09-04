using System;
using static Lib.Class1;

namespace ConsoleApp
{
    class program
    {
        public static void Main()
        {
            List<int> primes = new();
            List<int> factors = new();
            List<int> divisors = new();
            List<int> result = new();
            int num = 16;
            int start = 12;
            int finish = 144;
            result = GetNumsWith3Divisors(start,finish); 
            (primes, factors) = Factorization(num);
            divisors = AllDivisors(num);
            Console.WriteLine(string.Join(",", primes));
            Console.WriteLine(string.Join(",", factors));
            Console.WriteLine(string.Join(",", divisors));
            Console.WriteLine(string.Join(",", result));    
        }
    }
}