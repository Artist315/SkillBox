using Extensions;


//asdaww awdadsdw 123 123 dqwea a a d 23 ea asdqw    asd wqe asd daw  asdwqad 
var revertedSentence = ReversWords(InputExtesions.ReadStringInput("Введите строку"));



OutputExtesions.PrintArray(revertedSentence);

Console.ReadKey();



static string[] ReversWords(string inputString)
{
    var stringArray = SplitText(inputString);

    string[] outputArray = new string[stringArray.Length];
    for (int i = stringArray.Length-1; i >= 0; i--)
    {
        var t = stringArray[i];
        outputArray[stringArray.Length-1 - i] = stringArray[i];
    }
    
    return outputArray;
}

static string[] SplitText(string text)
{

    string cuurentRow = string.Empty;
    int i = 0;
    var array = new string[text.Count(x => x == ' ')];
    foreach (var item in text)
    {

        if (item != ' ')
        {
            cuurentRow += item;
        }
        else
        {
            array[i] = (cuurentRow);
            i++;
            cuurentRow = string.Empty;
        }

    }
    return array;
}
