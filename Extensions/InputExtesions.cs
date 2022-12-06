using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class InputExtesions
    {
        public static T ReadInputClass<T>(string message = null) where T : class
        {
            string input = Console.ReadLine();

            while (!(input is T))
            {
                Console.WriteLine("Введите длину последовательности");
            }

            return input as T;
        }

        public static int ReadIntInput(string message = null)
        {
            Console.WriteLine($"{message}");
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Неверный формат, введите целое число");
            }
            return input;
        }
    }
}
