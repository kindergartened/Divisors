using System;
using System.Security.Cryptography.X509Certificates;

namespace Testing
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsDivisortest()
        {
            int divisor = 4;
            int divisor2 = 2;
            bool exprethion = divisor % divisor2 == 0;
            Assert.AreEqual(exprethion,IsDivisor(divisor2,divisor));

        }
        [Test]
        public void IsPrimeTest()
        {
            bool IsPrimeTesting(int num)
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                        return false;
                }
                return true;
            }

            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                int n = rnd.Next();
                bool num = IsPrimeTesting(n);
                Assert.AreEqual(num, IsPrime(n));
            }
        }
        [Test]
        public void FactorizationTest()
        {
            List<int> primes = new();
            primes.Add(2); 
            primes.Add(3);
            int num = 72;
            List<int> factors = new();
            factors.Add(3);
            factors.Add(2);
            Assert.AreEqual((primes,factors),Factorization(num));

        }
        [Test]  
        public void AllDivisorsTest()
        {
            static List<long> FindDivisors(long number)
            {
                List<long> divisors = new List<long>();

                for (long i = 1; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        divisors.Add(i);
                        if (i != number / i)
                        {
                            divisors.Add(number / i);
                        }
                    }
                }
                return divisors;
            }

            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                int n = rnd.Next();
                List<long>  List = FindDivisors(n);
                Assert.AreEqual(List, AllDivisors(n));
            }
            
        }
        [Test]
        public void PrimeInRangeTest()
        {
            static List<long> FindPrimesInRange(long n, long m)
            {
                bool[] isPrime = new bool[m + 1];
                List<long> primes = new List<long>();

                for (long i = 2; i <= m; i++)
                {
                    isPrime[i] = true;
                }

                for (long p = 2; p * p <= m; p++)
                {
                    if (isPrime[p])
                    {
                        for (long i = p * p; i <= m; i += p)
                        {
                            isPrime[i] = false;
                        }
                    }
                }

                for (long i = Math.Max(2, n); i <= m; i++)
                {
                    if (isPrime[i])
                    {
                        primes.Add(i);
                    }
                }

                return primes;
            }

            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                long n = rnd.Next(1, 100000);
                long m = rnd.Next(1, 100000);
                List<long> List = FindPrimesInRange(n,m);
                Assert.AreEqual(List, PrimeInRange(n,m));
            }

        }
    }
}