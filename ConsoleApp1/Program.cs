using System;
using static Lib.Class1;

namespace ConsoleApp
{
    class program
    {
        public static void Main()
        {
            List<long> primes = new();
            List<long> factors = new();
            List<long> divisors = new();
            List<long> result = new();
            long num = 16;
            long start = 1;
            long finish = 100000000000000;
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