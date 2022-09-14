Console.WriteLine("Введите длину последовательности");
int len;
while (!int.TryParse(Console.ReadLine(), out len))
{
    Console.WriteLine("Введите длину последовательности");
}
int minValue = int.MaxValue;

for (int i = 0; i < len; i++)
{
    Console.WriteLine($"Введите {i+1}-ое число");
    int value;
    while (!int.TryParse(Console.ReadLine(), out value))
    {
        Console.WriteLine($"Введите {i+1}-ое число");
    }
    if (value < minValue)
    {
        minValue = value;
    }
}

Console.WriteLine($"Минимальное число {minValue}");