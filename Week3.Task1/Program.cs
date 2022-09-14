Console.WriteLine("Введите целое число");
int input ;
while (!int.TryParse(Console.ReadLine(), out input))
{
    Console.WriteLine("Введите целое число");
}

if (input % 2 == 0)
{
    Console.WriteLine("Вы ввели чётное число");
}
else
{
    Console.WriteLine("Вы ввели нечётное число");
}
Console.ReadKey(true);