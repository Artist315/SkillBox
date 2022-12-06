using Extensions;

var rowN = InputExtesions.ReadIntInput("Введите количетво строк");
var columnN = InputExtesions.ReadIntInput("Введите количетво столбцов");

var matrix = new int[rowN, columnN];
var rand = new Random();
int sum = 0;

for (int i = 0; i < rowN; i++)
{
    for (int j = 0; j < columnN; j++)
    {
        matrix[i, j] = rand.Next(-100,100);
        sum += matrix[i, j];
        Console.Write($"{matrix[i, j]} \t");
    }
    Console.Write("\n");
}

Console.Write("\n");
Console.Write($"Sum of elements is {sum}");

Console.ReadKey();