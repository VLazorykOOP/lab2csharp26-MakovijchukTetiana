using System;

namespace Lab2
{
    public class Task2
    {
        public static void Execute()
        {
            Console.WriteLine("\n[Завдання 2]");
            Console.Write("Кількість чисел n = ");
            int n = int.Parse(Console.ReadLine());
            
            if (n <= 0) 
            {
                Console.WriteLine("Масив не може бути порожнім!");
                return;
            }

            double[] a = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}]= ");
                a[i] = double.Parse(Console.ReadLine());
            }
            
            double minVal = a[0];
            int lastIdx = 0;
            
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] <= minVal) 
                { 
                    minVal = a[i]; 
                    lastIdx = i; 
                }
            }
            Console.WriteLine($"Останній мінімум: a[{lastIdx}] = {minVal}");
        }
    }
}
