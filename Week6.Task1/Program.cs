using Extensions;

string fileName = "Task1.txt";
int? option;

CheckIfExists(fileName);
do
{
    Console.WriteLine();
    Console.WriteLine("Выберите действие:");
    Console.WriteLine("1 - Добавить запись сотрудника");
    Console.WriteLine("2 - Показать существующие записи");
    Console.WriteLine("0 - выход из программы");
    Console.WriteLine();

    option = InputExtesions.ReadIntInput(approvedValues : new int[] {1,2,0 });

    switch (option)
    {
        case 1:
            {
                WriteToFile(fileName);
                break;
            }
        case 2:
            {
                ReadFile(fileName);
                break;
            }
        default:
            break;
    }
    } while (option!=0);

Console.ReadKey();

void CheckIfExists(string fileName)
{
    if (!File.Exists(fileName))
    {
        File.Create(fileName).Close();
    }    
}

void ReadFile(string fileName)
{
    using (StreamReader reader = new StreamReader(fileName))
    {
        string line;
        do
        {
            line = reader.ReadLine();
            line = line?.Replace("#", " ");
            Console.WriteLine(line);
        } while (line != null);
        
    }
}

void WriteToFile(string fileName)
{
    using (StreamWriter writer = new StreamWriter(fileName,true))
    {
        var input = InputExtesions.ReadStringInput("Введите данные:");
        writer.WriteLine(input);
        writer.Flush();
    }
}