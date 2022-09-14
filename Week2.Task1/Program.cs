string fullName = "Григорьев Артём";// Ф.И.О.
int age = 24; // Возраст
string email = "artist315.2010@gmail.com"; //Email
float scoreProgramming = 100;// Баллы по программированию
float scoreMath = 100; //Баллы по математике
float scorePhisics = 100; //Баллы по физике

Console.WriteLine($"Hi, my name is {fullName}.");
Console.WriteLine($"I am {age} years old.");
Console.WriteLine($"contact email: {email}.");
Console.WriteLine($"My scores for programming, physics and math are " +
    $"{scoreProgramming}, {scoreMath}, {scorePhisics} respectivly.");
Console.ReadKey(true);
