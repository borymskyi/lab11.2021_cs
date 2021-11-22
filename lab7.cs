using System;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            int M;
            Console.Write("Введите номер текущего месяца -> ");
            M = Convert.ToInt32(Console.ReadLine());
            switch (M)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Зима");
                    break;
                
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Весна");
                    break;
                
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Лето");
                    break;
                
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Осень");
                    break;
                
                default:
                    Console.WriteLine("Число должно быть в диапазоне 1-12");
                    break;
            }
            Console.ReadLine();
        }
    }
}
