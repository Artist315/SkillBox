using Extensions;

HashSet<int> storage = new HashSet<int>();

while (true)
{
    var input = InputExtesions.ReadStringInput("Введите число:");
    if (string.IsNullOrEmpty(input))
    {
        break;
    }
    if (!int.TryParse(input, out int result))
    {
        continue;
    }
    else
    {
        AddElement(result);
    }

}

void AddElement(int newValue)
{
    if (!storage.Contains(newValue))
    {
        storage.Add(newValue);
        Console.WriteLine("Новое число было добавлено");
    }
    else
    {
        Console.WriteLine("Это число уже было добавлено");
    }
}