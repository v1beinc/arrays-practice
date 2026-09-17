using System;

namespace Task3.Unique
{
    class Program
    {
        static bool IsExists(int[] arr, int el)
        {
            foreach (int item in arr)
            {
                if (item == el)
                {
                    return true;
                }
            }
            return false;
        }

        static void Main()
        {
            int[] arr = new int[10];
            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 6);
            }

            Console.WriteLine(string.Join(", ", arr));

            int[] newArr = new int[arr.Length];
            int count = 0;

            foreach (int el in arr)
            {
                if (!IsExists(newArr, el))
                {
                    newArr[count] = el;
                    count++;
                }
            }

            int[] result = new int[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = newArr[i];
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}