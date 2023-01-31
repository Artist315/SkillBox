using Extensions;
using Week7.Task1;

const string fileName = "Task1.txt";
int? option;
Repository repository = new Repository();

repository.SetDirectory(fileName);

do
{
    Console.WriteLine("нажмите любую клавишу");
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine("Выберите действие:");
    Console.WriteLine("1 - Добавить запись сотрудника");
    Console.WriteLine("2 - Показать существующие записи");
    Console.WriteLine("3 - Очистить записи");
    Console.WriteLine("4 - Удадение записи по ID");
    Console.WriteLine("5 - Найти запись по ID");
    Console.WriteLine("6 - Найти записи в диапозоне дат");
    Console.WriteLine("0 - выход из программы");
    Console.WriteLine();

    option = InputExtesions.ReadIntInput(approvedValues: new int[] { 1, 2, 3, 4, 5, 6, 0 });

    switch (option)
    {
        case 1:
            {
                Console.WriteLine("Введите данные:");
                var input = InputWorkerData();
                repository.AddWorker(input);
                break;
            }
        case 2:
            {
                var workers = repository.GetAllWorkers();
                OutputExtesions.PrintArray(workers);
                break;
            }

        case 3:
            {
                repository.Clear();
                Console.WriteLine("Список очищен");
                break;
            }
        case 4:
            {
                var id = InputExtesions.ReadIntInput("введите ID");
                repository.DeleteWorkerById(id);
                break;
            }
        case 5:
            {
                var id = InputExtesions.ReadIntInput("введите ID");
                Worker worker;
                if (repository.GetWorkerById(id, out worker))
                {
                    Console.WriteLine(worker.ToString());
                    break;
                }
                Console.WriteLine("Такой записи нет");
                break;
            }
        case 6:
            {

                var dateFrom = InputExtesions.ReadStringInput(false, "Введите дату от");
                var dateTo = InputExtesions.ReadStringInput(false, "Введите дату до");
                var workers = repository.GetWorkerByCreatedAt(dateFrom, dateTo);
                OutputExtesions.PrintArray(workers.ToArray());
                break;
            }
        default:
            break;
    }
} while (option != 0);

Console.ReadKey();

Worker InputWorkerData()
{
    var id = InputExtesions.ReadIntInput("введите ID");
    var fullName = InputExtesions.ReadStringInput(false, "введите Ф. И. О.");
    var age = InputExtesions.ReadIntInput("введите Возраст");
    var heigh = InputExtesions.ReadIntInput("введите Рост");
    var dateOfBirth = InputExtesions.ReadStringInput(false, "Дату рождения");
    var placeOfBirth = InputExtesions.ReadStringInput(false, "Место рождения");

    var worker = new Worker()
    {
        Id = id,
        CreatedAt = DateTime.MinValue,
        FullName = fullName,
        Age = age,
        Higth = heigh,
        DateOfBirth = Convert.ToDateTime(dateOfBirth),
        PlaceOfBirth = placeOfBirth,
    };

    return worker;
}