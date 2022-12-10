using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class OutputExtesions
    {
        public static void PrintArray<T>(T[] array)
        {
            foreach (var element in array)
            {
                Console.WriteLine(element?.ToString() ?? string.Empty);
            }
        }
    }
}
