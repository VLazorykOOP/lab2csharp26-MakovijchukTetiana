using System;
using System.Text; 

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n Лабораторна робота №2 ");
                Console.WriteLine("1. Завдання 1 (Кількість елементів поза інтервалом)");
                Console.WriteLine("2. Завдання 2 (Останній мінімальний елемент)");
                Console.WriteLine("3. Завдання 3 (Матриця A в степені p)");
                Console.WriteLine("4. Завдання 4 (Східчастий масив: суми)");
                Console.WriteLine("0. Вихід");
                Console.Write("Виберіть номер завдання: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": 
                        Task1.Execute(); 
                        break;
                    case "2": 
                        Task2.Execute(); 
                        break;
                    case "3": 
                        Task3.Execute(); 
                        break;
                    case "4": 
                        Task4.Execute(); 
                        break;
                    case "0": 
                        exit = true; 
                        break;
                    default: 
                        Console.WriteLine("Невірний вибір! Спробуйте ще раз."); 
                        break;
                }
            }
        }
    }
}