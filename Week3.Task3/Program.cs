Console.WriteLine("Введите число");
int input;
while (!int.TryParse(Console.ReadLine(), out input))
{
    Console.WriteLine("Введите число");
}
bool isSimple = true;

for (int i = 2; i < input; i++)
{
    if (input % i == 0)
    {
        isSimple = false;
        break;
    }
}

if (!isSimple)
{
    Console.WriteLine("Число не является простым");
}
else
{
    Console.WriteLine("Число является простым");
}

