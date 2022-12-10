using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class InputExtesions
    {
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

        public static string ReadStringInput(string message = null)
        {
            Console.WriteLine($"{message}");

            return Console.ReadLine();
        }
    }
}
