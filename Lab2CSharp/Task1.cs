using System;

namespace Lab2
{
    public class Task1
    {
        
        public static int CountOutsideInterval(int[] array, int min, int max)
        {
            int count = 0;
            foreach (int x in array)
            {
                if (x < min || x > max) count++;
            }
            return count;
        }

        public static void Execute()
        {
            Console.WriteLine("\n[Завдання 1 - Спосіб 1: Одновимірний масив]");
            Console.Write("Розмірність масиву n = ");
            int n = int.Parse(Console.ReadLine());
            int[] a1 = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}]= ");
                a1[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Нижня межа інтервалу: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Верхня межа інтервалу: ");
            int max = int.Parse(Console.ReadLine());

            
            int count1 = CountOutsideInterval(a1, min, max);
            Console.WriteLine($"Кількість елементів поза інтервалом (1D): {count1}");

         
            Console.WriteLine("\n[Завдання 1 - Спосіб 2: Двовимірний масив]");
            Console.Write("Кількість рядків матриці = ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Кількість стовпців матриці = ");
            int cols = int.Parse(Console.ReadLine());
            
            int[,] a2 = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"a[{i},{j}]= ");
                    a2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int count2 = 0;
            // Цикл foreach перебирає всі елементи навіть у двовимірному масиві
            foreach (int x in a2) 
            {
                if (x < min || x > max) count2++;
            }
            Console.WriteLine($"Кількість елементів поза інтервалом (2D): {count2}");
        }
    }
}

