using System;

namespace Task2.InputSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //запрос кол-во элементов
            int size = 0;
            while (size <= 0)
            {
                Console.Write("Введите количество элементов (N > 0): ");
                if (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
                {
                    Console.WriteLine("Ошибка: введите целое положительное число.");
                }
            }

            int[] numbers = new int[size];

            // ввод элементов с обработкой
            for (int i = 0; i < size; i++)
            {
                bool success = false;
                while (!success)
                {
                    Console.Write($"Элемент [{i}]: ");
                    try
                    {
                        numbers[i] = Convert.ToInt32(Console.ReadLine());
                        success = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ошибка: введите корректное целое число!");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Ошибка: число вышло за границы int!");
                    }
                }
            }

            Console.WriteLine();

            // прямой порядок
            Console.WriteLine("Исходный массив:  " + string.Join(", ", numbers));

            // обратный порядок
            int[] reversed = new int[size];
            for (int i = 0; i < size; i++)
            {
                reversed[i] = numbers[size - 1 - i];
            }
            Console.WriteLine("Обратный порядок: " + string.Join(", ", reversed));

            // сортировка по возрастанию
            int[] sorted = (int[])numbers.Clone();
            Array.Sort(sorted);
            Console.WriteLine("Отсортированный:  " + string.Join(", ", sorted));

            // поиск максимума и минимума
            int min = numbers[0];
            int max = numbers[0];
            for (int i = 1; i < size; i++)
            {
                if (numbers[i] < min) min = numbers[i];
                if (numbers[i] > max) max = numbers[i];
            }

            Console.WriteLine($"Максимум: {max}");
            Console.WriteLine($"Минимум: {min}");
        }
    }
}