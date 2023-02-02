using Extensions;

Dictionary<string,List<string>> telephoneBook = new Dictionary<string, List<string>>();

FillBook();

PrintTephoneBook();

FindByName(InputExtesions.ReadStringInput("Найдите номера по имени"));

#region Methods

void FindByName(string name)
{
    if (telephoneBook.TryGetValue(name, out List<string> value))
    {
        var values = string.Join(", ", value);
        Console.WriteLine($"{name} номера: {values}");
    }
    else
    {
        Console.WriteLine($"Нет такой записи");
    }
}

void FillBook()
{
    Console.WriteLine("добавьте пользователя и номер в формате Имя_Номер");
    Console.WriteLine("");
    while (true)
    {
        string input = InputExtesions.ReadStringInput("добавьте пользователя и номер");
        if (string.IsNullOrEmpty(input))
        {
            break;
        }
        var data = SplitInput(input);

        AddData(data);
    }
}

string[] SplitInput(string input)
{
    string[] split = input.Split("_");
    if (split.Count() != 2)
    {
        return null;
    }
    return split;
}

void AddData(string[] input)
{
    if (telephoneBook.TryGetValue(input[0], out List<string> value))
    {
        value.Add(input[1]);
        telephoneBook[input[0]] = value;
    }
    else
    {
        var newValue = new List<string>() { input[1] };
        telephoneBook.Add(input[0], newValue);
    }
}

void PrintTephoneBook()
{
    foreach (var item in telephoneBook)
    {
        var values = string.Join(", ", item.Value);
        Console.WriteLine($"{item.Key} номера: {values}");
    }
}

#endregion