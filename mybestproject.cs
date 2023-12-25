using System;

namespace RandomArray
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите длину массива: ");
            int length = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(1, 101); 
            }
            Console.WriteLine("Сгенерированный массив: " + string.Join(", ", array));

            int sum = 0;
            int count = 0;
            foreach (int num in array)
            {
                if (num % 2 != 0)
                {
                    sum += num;
                    count++;
                }
            }
            if (count > 0)
            {
                double average = (double)sum / count;
                Console.WriteLine("Среднее арифметическое нечетных чисел: " + average);
            }
            else
            {
                Console.WriteLine("В массиве нет нечетных чисел");
            }
        }
    }
}
