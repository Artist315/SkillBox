using Extensions;

var rowN = InputExtesions.ReadIntInput("Введите количетво строк");
var columnN = InputExtesions.ReadIntInput("Введите количетво столбцов");

var matrixA = new int[rowN, columnN];
var matrixB = new int[rowN, columnN];
var matrixSum = new int[rowN, columnN];
var rand = new Random();

for (int i = 0; i < rowN; i++)
{
    for (int j = 0; j < columnN; j++)
    {
        matrixA[i, j] = rand.Next(-100, 100);
        matrixB[i, j] = rand.Next(-100, 100);
        matrixSum[i, j] = matrixA[i, j] + matrixB[i, j];
    }
}
Console.Write("\n");

PrintMatrix(matrixA, rowN, columnN);
PrintMatrix(matrixB, rowN, columnN);
Console.WriteLine($"Sum of maxrix is:");
PrintMatrix(matrixSum, rowN, columnN);

Console.Write("\n");

Console.ReadKey();

static void PrintMatrix(int[,] matrix, int rowN, int columnN)
{
    for (int i = 0; i < rowN; i++)
    {
        for (int j = 0; j < columnN; j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.Write("\n");
    }
    Console.Write("\n");
}
