using System;

namespace Lab2
{
    public class Task4
    {
        public static void Execute()
        {
            Console.WriteLine("\n[Завдання 4]");
            Console.Write("Кількість рядків n = ");
            int n = int.Parse(Console.ReadLine());
            int[][] a = new int[n][];
            
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Елементів у рядку {i}: ");
                int m = int.Parse(Console.ReadLine());
                a[i] = new int[m];
                
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"a[{i}][{j}]= ");
                    a[i][j] = int.Parse(Console.ReadLine());
                }
            }
            
            Console.Write("Індекс початку (n1): ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Індекс кінця (n2): ");
            int n2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("\nРезультати:");
            for (int i = 0; i < n; i++)
            {
                int s = 0;
                for (int j = 0; j < a[i].Length; j++) 
                {
                    if (j >= n1 && j <= n2) s += a[i][j];
                }
                Console.WriteLine($"Рядок {i}, сума елементів з {n1} по {n2} індекс: {s}");
            }
        }
    }
}

