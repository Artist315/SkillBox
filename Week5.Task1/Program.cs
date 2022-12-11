using Extensions;


//asdaww awdadsdw 123 123 dqwea a a d 23 ea asdqw asd wqe asd daw asdwqad 
var inputString = InputExtesions.ReadStringInput("Введите строку");

var stringArray = SplitText(inputString);

OutputExtesions.PrintArray(stringArray);



static string[] SplitText(string text)
{

    string cuurentRow = string.Empty;
    int i = 0;
    var array = new string[text.Count(x => x == ' ')+1];
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
    if (cuurentRow != string.Empty)
    {
        array[i] = (cuurentRow);
    }
    return array;
}
