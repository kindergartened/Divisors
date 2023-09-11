using System.Net.Http.Headers;

namespace Lib
{
    public class Class1
    {
        /// <summary>
        /// Разбивает число на его простые множители
        /// </summary>
        /// <param name="num">Разбиваемое число</param>
        /// <returns>Два листа с целыми числами</returns>
        public static (List<long>, List<long>) Factorization(long num)
        {
            List<long> primes = new();
            int temp = 0;
            List<long> factors = new();

            for (long i = 2; i <= num; i++)
            {
                while (num % i == 0)
                {
                    primes.Add(i);
                    num /= i;
                }
            }
            factors.Add(1);
            for (int i = 0; i < primes.Count-1; i++)
            {
                if (primes[i] == primes[i+1])
                {
                    factors[temp]++;
                }
                else
                {
                    temp++;
                    factors.Add(1);
                }
            }
            return (primes.Distinct().ToList(), factors);
        }
        /// <summary>
        /// Возвращает лист простых чисел в диапазоне от n до m. Использует алгоритм 
        /// "Решето Эратосфена" для поиска простых чисел и представляет их в виде списка. 
        /// Этот алгоритм имеет сложность O(n log log n) и является эффективным для больших чисел.
        /// </summary>
        /// <param name="n">Начальное число</param>
        /// <param name="m">Конечное число</param>
        /// <returns></returns>
        public static List<long> PrimeInRange(long n, long m)
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
        /// <summary>
        /// Является ли число d делителем числа n
        /// </summary>
        /// <param name="d">Целое число</param>
        /// <param name="n">Целое число</param>
        /// <returns>True или False</returns>
        public static bool IsDivisor(long d, long n)
        {
            return (n % d == 0);
        }
        /// <summary>
        /// Лист делителей числа
        /// </summary>
        /// <param name="num">Число</param>
        /// <returns>Лист целых чисел</returns>
        public static List<long> AllDivisors(long num)
        {
            List<long> result = new();
            for (int i = 1; i <= Math.Sqrt(num); i++)
            {
                if (IsDivisor(i, num))
                {
                    result.Add(i);
                    if (num / i != i)
                        result.Add(num / i);
            }
            }
            return result;
        }
        /// <summary>
        /// Проверяет, является ли число простым. Проверяет только делители до квадратного корня из числа
        /// </summary>
        /// <param name="num">Число</param>
        /// <returns>true/false</returns>
        public static bool IsPrime(long n)
        {
            if (n <= 1) return false;
            if (n <= 3) return true;

            if (n % 2 == 0 || n % 3 == 0) return false;

            for (long i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;
            }

            return true;
        }

        // Задание с занятия
        //
        // |
        // |
        // v

        /// <summary>
        /// Метод, возвращающий лист чисел, имеющих ровно 3 делителя за исключением 1 и самого себя.
        /// </summary>
        /// <param name="start">Начало диапазона</param>
        /// <param name="finish">Конец диапазона</param>
        /// <returns>Лист целых чисел</returns>
        public static List<long> GetNumsWith3Divisors(long start, long finish)
        {
            List<long> result = new();
            for (long i = start; i <= finish; i++)
            {
                if (Math.Sqrt(i)%1==0)
                {
                    if (AllDivisors(i).Count == 5)
                    {
                        result.Add(i);
                    }
                }
            }
            return result;
        }
    }
}