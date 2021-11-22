/*
 * UA
 * Ввести назву району, назву населеного пункту і назву вулиці свого
 * місця народження як одне дане рядкового типу.
 *
 * Визначити довжину рядка і кількість букв "а" в ньому.
 *
 * Виконати додаткове завдання з списку за своїм варіантом. №2(Визначте, скільки букв "a" в Назві вулиці).
 */
using System.Linq;
using System;

namespace Lab18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести назву району, назву населеного пункту і назву вулиці
            string s = Console.ReadLine();
            
            //Визначити довжину рядка і кількість букв "а" в ньому.
            Console.WriteLine(s.Length);
            Console.WriteLine(s.Count(ch => ch == 'а' || ch == 'А'));
            
            //Виконати додаткове завдання з списку за своїм варіантом. №2(Визначте, скільки букв "a" в Назві вулиці)
            string[] street = s.Split();
            string string_street = street[2];
            Console.WriteLine(string_street.Count(ch => ch == 'а' || ch == 'А'));
        }
    }
}
