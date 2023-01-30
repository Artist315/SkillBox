using Extensions;

string fileName = "Task1.txt";
int? option;
bool shortInput = false;

CheckIfExists(fileName);
do
{
    Console.WriteLine("нажмите любую клавишу");
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine("Выберите действие:");
    Console.WriteLine("1 - Добавить запись сотрудника");
    Console.WriteLine("2 - Показать существующие записи");
    Console.WriteLine("3 - для смены типа ввода. Текущий тип ввода {0}. ", shortInput ? "короткий" : "длинный");
    Console.WriteLine("0 - выход из программы");
    Console.WriteLine();

    option = InputExtesions.ReadIntInput(approvedValues : new int[] {1,2,3,0 });

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
        case 3:
            {
                shortInput =!shortInput;
                break;
            }
        default:
            break;
    }

} while (option!=0);

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
        string line;
        if (shortInput)
        {

            line = InputExtesions.ReadStringInput("Введите данные:");
        }
        else
        {
            var id              = InputExtesions.ReadStringInput(false, "введите ID");
            var createdAt       = InputExtesions.ReadStringInput(false, "введите Дату и время добавления записи");
            var fullName        = InputExtesions.ReadStringInput(false, "введите Ф. И. О.");
            var age             = InputExtesions.ReadStringInput(false, "введите Возраст");
            var heigh           = InputExtesions.ReadStringInput(false, "введите Рост");
            var dateOfBirth     = InputExtesions.ReadStringInput(false, "Дату рождения");
            var placeOfBirth    = InputExtesions.ReadStringInput(false, "Место рождения");

            List<string> data = new List<string>()
            {
                id,
                createdAt,
                fullName,
                age,
                heigh,
                dateOfBirth,
                placeOfBirth
            };

            line = string.Join("#", data);
        }

        writer.WriteLine(line);
        writer.Flush();
    }
}