using Extensions;


//asdaww awdadsdw 123 123 dqwea a a d 23 ea asdqw    asd wqe asd daw  asdwqad 
var inputString = InputExtesions.ReadStringInput("Введите строку");

var stringArray = inputString.Split(' ');

OutputExtesions.PrintArray(stringArray);



static string[] SplitText(string text)
{
    string cuurentRow = string.Empty;
    var array = new string[0];
    foreach (var item in text)
    {
        
        if (item != ' ')
        {
            cuurentRow.Append(item);
        }
        else
        {
            array.Append(cuurentRow);
            cuurentRow = string.Empty;
        }

    }
    return array;
}
