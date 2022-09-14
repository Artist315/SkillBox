Console.WriteLine("Введите максимальное число");
int targetValue;
while (!int.TryParse(Console.ReadLine(), out targetValue))
{
    Console.WriteLine("Введите максимальное число");
}

int rand = new Random().Next(0, targetValue + 1);

while (true)
{
    Console.WriteLine("Угадайте число");
    var input = Console.ReadLine();
    if (string.IsNullOrEmpty(input))
    {
        break;
    }
    else
    {
        int inputValue;

        if (!int.TryParse(input, out inputValue))
        {
            continue;
        }
        else if (inputValue < rand)
        {
            Console.WriteLine("Загаданное число больше");
        }
        else if (inputValue > rand)
        {
            Console.WriteLine("Загаданное число меньше");
        }
        else
        {
            break;
        }
    }
}


Console.WriteLine($"Загаданное число {rand}");
