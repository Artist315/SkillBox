using Extensions;


//asdaww awdadsdw 123 123 dqwea a a d 23 ea asdqw    asd wqe asd daw  asdwqad 
var revertedSentence = ReversWords(InputExtesions.ReadStringInput("Введите строку"));



OutputExtesions.PrintArray(revertedSentence);

Console.ReadKey();

static string[] ReversWords(string inputString)
{
    var stringArray = inputString.Split(' ');

    string[] outputArray = new string[stringArray.Length];
    for (int i = stringArray.Length-1; i >= 0; i--)
    {
        outputArray[stringArray.Length - 1 - i] = stringArray[i];
    }
    
    return outputArray;
}
