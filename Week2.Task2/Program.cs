float scoreProgramming = 34;// Баллы по программированию
float scoreMath = 43; //Баллы по математике
float scorePhisics = 54; //Баллы по физике

Console.WriteLine("Press any key to calculate total score.");
Console.ReadKey(true);

var totalScore = scoreProgramming + scoreMath + scorePhisics;
Console.WriteLine($"Total score: {totalScore}.");
Console.WriteLine("Press any key to calculate average score.");
Console.ReadKey(true);

var avgScore = totalScore/3;
Console.WriteLine($"Average score: {string.Format("{0:0.00}", avgScore) }.");
Console.ReadKey(true);

