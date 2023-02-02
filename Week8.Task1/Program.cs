using Extensions;

const int min = 25;
const int max = 50;
const int length = 100;
const int maxRand = 100;

var intList = FillListWithRandom(length, maxRand);
var filteredList = DeleteOnMinMaxCondition(intList, min, max);
PrintList();

List<int> FillListWithRandom(int length, int maxRand)
{
    var rand = new Random();
    var list = new List<int>();
    for (int i = 0; i < length; i++)
    {
        list.Add(rand.Next(0, maxRand));
    }
    return list;
}

List<int> DeleteOnMinMaxCondition(List<int> list, int min, int max)
{
    var filteredList = list.Where(item => item > min && item < max).ToList();
    return filteredList;
}

void PrintList()
{
    OutputExtesions.PrintList<int>(filteredList);
}