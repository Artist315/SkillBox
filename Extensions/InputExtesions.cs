﻿
namespace Extensions
{
    public static class InputExtesions
    {
        public static int ReadIntInput(string message = null, int[] approvedValues = null)
        {
            if (!string.IsNullOrEmpty(message))
            {
                Console.WriteLine($"{message}");
            }
            
            int input;
            while (!Check(Console.ReadLine(), out input))
            {
                if (approvedValues != null)
                {
                    Console.WriteLine("Неверный формат или число вне допустимого списка занчений");
                }
                else
                {
                    Console.WriteLine("Неверный формат, введите целое число");
                }
            }
            return input;

            bool Check(string input, out int result)
            {
                var isInt = int.TryParse(input, out result);
                if (approvedValues != null && isInt)
                {
                    isInt = approvedValues.Contains(result);
                }
                return isInt;
            }
        }

        public static string ReadStringInput(string message = null)
        {
            Console.WriteLine($"{message}");

            return Console.ReadLine();
        }

        public static string ReadStringInput(bool allowEmpty, string message = null)
        {
            Console.WriteLine($"{message}");
            string input;
            if (!allowEmpty)
            {
                while (string.IsNullOrEmpty(input = Console.ReadLine()))
                {
                    Console.WriteLine($"недопустима пустая строка");
                }
            }
            else
            {
                input = Console.ReadLine();
            }

            return input;
        }
    }
}
