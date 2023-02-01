
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
        public static void PrintList<T>(List<T> list)
        {
            foreach (var element in list)
            {
                Console.WriteLine(element?.ToString() ?? string.Empty);
            }
        }
    }
}
