Console.WriteLine("Введите количество карт");
int input;
while (!int.TryParse(Console.ReadLine(), out input))
{
    Console.WriteLine("Введите количество карт");
}

int totalValue = 0;
for (int i = 0; i < input; i++)
{
    Console.WriteLine($"Введите значение {i+1}-ой карты");
    string cardType = Console.ReadLine().ToUpper();
    switch (cardType)
    {
        case "K":
            totalValue += 10;
            continue;
        case "Q":
            totalValue += 10;
            continue;
        case "T":
            totalValue += 10;
            continue;
        case "J":
            totalValue += 10;
            continue;
        default:
            break;
    }
    int cardValue = 0;
    if (!int.TryParse(cardType, out cardValue))
    {
        i--;
    }
    totalValue += cardValue;
}

Console.WriteLine($"Ваша сумма {totalValue}");
Console.ReadKey(true);