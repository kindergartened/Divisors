namespace Lib
{
    public class Class1
    {
        static (List<int>, List<int>) Factorization(int num)
        {
            List<int> result = new();
            return (result, result);
        }
        /// <summary>
        /// Возвращает лист простых чисел в диапазоне 
        /// </summary>
        /// <param name="n">Начальное число</param>
        /// <param name="m">Конечное число</param>
        /// <returns></returns>
        static List<int> PrimeInRange(int n, int m)
        {
            List<int> result = new();
            for (int number = n; number <= m; number++)
            {
                if (number > 1)
                {
                    bool flag = true;
                    for (int i = 2; i <= Math.Sqrt(number); i++)
                        if ((number % i) == 0)
                        {
                            flag = false;
                            break;
                        }
                    if (flag)
                        result.Add(number);
                }
            }
            return result;
        }
        /// <summary>
        /// Лист делителей числа
        /// </summary>
        /// <param name="num">Число</param>
        /// <returns>Лист целых чисел</returns>
        static List<int> AllDivisors(int num)
        {
            return new List<int>();
        }
        /// <summary>
        /// Проверяет, является ли число простым
        /// </summary>
        /// <param name="num">Число</param>
        /// <returns>true/false</returns>
        static bool IsPrime(int num)
        {
            return false;
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