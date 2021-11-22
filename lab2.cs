using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 2.2
            try
            {
                Console.WriteLine("Введите первое число");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                int y = Convert.ToInt32(Console.ReadLine());
                int result = x / y;
                Console.WriteLine($"Результат: {result}");
            }
            catch
            {
                Console.WriteLine("Возникло исклчение");
            }
        }
    }
}
