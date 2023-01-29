using Extensions;
using Week7.Task1;

const string fileName = "Task1.txt";
int? option;
Repository repository = new Repository();

repository.SetDirectory(fileName);

do
{
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine("Выберите действие:");
    Console.WriteLine("1 - Добавить запись сотрудника");
    Console.WriteLine("2 - Показать существующие записи");
    Console.WriteLine("0 - выход из программы");
    Console.WriteLine();

    option = InputExtesions.ReadIntInput(approvedValues: new int[] { 1, 2, 0 });

    switch (option)
    {
        case 1:
            {
                var input = InputExtesions.ReadStringInput("Введите данные:");

                repository.AddWorker(new Worker(input));
                break;
            }
        case 2:
            {
                var workers = repository.GetAllWorkers();
                OutputExtesions.PrintArray(workers);
                break;
            }
        default:
            break;
    }

    Console.ReadKey(true);
} while (option != 0);

Console.ReadKey();

//void CheckIfExists(string fileName)
//{
//    if (!File.Exists(fileName))
//    {
//        File.Create(fileName).Close();
//    }
//}

//void ReadFile(string fileName)
//{
//    using (StreamReader reader = new StreamReader(fileName))
//    {
//        string line;
//        do
//        {
//            line = reader.ReadLine();
//            line = line?.Replace("#", " ");
//            Console.WriteLine(line);
//        } while (line != null);

//    }
//}

//string ReadInput()
//{
//    using (StreamWriter writer = new StreamWriter(fileName, true))
//    {
        

//        return input;
//    }
//}