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
        public static (List<int>, List<int>) Factorization(int num)
        {
            List<int> primes = new();
            int temp = 0;
            List<int> factors = new();

            for (int i = 2; i <= num; i++)
            {
                while (num % i == 0)
                {
                    primes.Add(i);
                    num /= i;
                }
            }
            primes.Sort();
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
        /// Возвращает лист простых чисел в диапазоне 
        /// </summary>
        /// <param name="n">Начальное число</param>
        /// <param name="m">Конечное число</param>
        /// <returns></returns>
        public static List<long> PrimeInRange(long n, long m)
        {
            List <long> result = new();
            for (long number = n; number <= m; number++)
            {
                if (IsPrime(number))
                {
                    result.Add(number);
                }
            }
            return result;
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
        /// Проверяет, является ли число простым
        /// </summary>
        /// <param name="num">Число</param>
        /// <returns>true/false</returns>
        public static bool IsPrime(long num)
        {
            return AllDivisors(num).Count==2;
        }

        // Задание с занятия
        //
        // |
        // |
        // v

        /// <summary>
        /// Метод, возвращающий лист чисел, имеющих ровно 3 делителя за исключением 1 и самого себя.
        /// </summary>
        /// <param name="start">Начало диапозона</param>
        /// <param name="finish">Конец диапозона</param>
        /// <returns>Лист целых чисел</returns>
        public static List<int> GetNumsWith3Divisors(int start, int finish)
        {
            List<int> result = new();
            for (int i = start; i <= finish; i++)
            {
                if (AllDivisors(i).Count == 5)
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}