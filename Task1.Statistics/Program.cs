using System;

namespace Task1.Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numbers = new int[10];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 101);
            }

            Console.WriteLine("Массив: " + string.Join(", ", numbers));

            long sum = 0;
            double product = 1.0;
            int evenCount = 0;

            // пдсчвет суммы и произв четн чисел
            foreach (int num in numbers)
            {
                sum += num;
                product *= num;
                if (num % 2 == 0)
                {
                    evenCount++;
                }
            }

            // расчет среднего арифм и элементов больше него
            double average = (double)sum / numbers.Length;

            int greaterThanAverageCount = 0;
            foreach (int num in numbers)
            {
                if (num > average)
                {
                    greaterThanAverageCount++;
                }
            }

            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Произведение: {product:E2}");
            Console.WriteLine($"Чётных чисел: {evenCount}");
            Console.WriteLine($"Больше среднего ({average:F1}): {greaterThanAverageCount}");
        }
    }
}