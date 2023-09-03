using System.Net.Http.Headers;

namespace Lib
{
    public class Class1
    {
        public static (List<int>, List<int>) Factorization(int num)
        {
            List<int> primes = new();
            int temp = 1;
            List<int> factors = new();

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                while (num % i == 0)
                {
                    primes.Add(i);
                    num /= i;
                }
            }
            primes.Sort();
            for (int i = 1; i < primes.Count; i++)
            {
                if (primes[i] == primes[i-1])
                {
                    temp++; 
                }
                else
                {
                    factors.Add(temp);
                    temp = 1;
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
        public static List<int> PrimeInRange(int n, int m)
        {
            List<int> result = new();
            for (int number = n; number <= m; number++)
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
        public static bool IsDivisor(int d, int n)
        {
            return (n % d == 0);
        }
        /// <summary>
        /// Лист делителей числа
        /// </summary>
        /// <param name="num">Число</param>
        /// <returns>Лист целых чисел</returns>
        public static List<int> AllDivisors(int num)
        {
            List<int> result = new();
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
        public static bool IsPrime(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
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
        /// <param name="start">Начальное число</param>
        /// <param name="finish">Конечное число</param>
        /// <returns>Лист с числами</returns>
        static List<int> GetNumsWith3Divisors(int start, int finish)
        {
            return new List<int>();
        }
    }
}