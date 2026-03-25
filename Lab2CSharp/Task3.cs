using System;

namespace Lab2
{
    public class Task3
    {
        public static void Execute()
        {
            Console.WriteLine("\n[Завдання 3 - Двовимірний масив]");
            Console.Write("Розмірність квадратної матриці n = ");
            int n = int.Parse(Console.ReadLine());
            int[,] A = new int[n, n];
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"A[{i},{j}] = ");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            
            Console.Write("Степінь p = ");
            int p = int.Parse(Console.ReadLine());
            
            int[,] res = (int[,])A.Clone();
            
            for (int step = 1; step < p; step++)
            {
                int[,] temp = new int[n, n];
                for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                for (int k = 0; k < n; k++)
                    temp[i, j] += res[i, k] * A[k, j];
                res = temp;
            }
            
            Console.WriteLine($"\nРезультат (матриця в {p} степені):");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++) 
                {
                    Console.Write("{0,5}", res[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}