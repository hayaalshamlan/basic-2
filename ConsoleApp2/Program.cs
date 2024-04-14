// See https://aka.ms/new-console-template for more information

//Control flow
int currentHour = 13;
if (currentHour >= 11 && currentHour <= 14)
{
    Console.WriteLine("Time for lunch!");
}

for (int i = 0; i < 11; i++)
{
    Console.WriteLine(i);
}

/// arrays

string[] daysOfWeek = { "sun", "mon", "tus", "wend", "thur"};
Console.WriteLine("days of the week:");
foreach (string day in daysOfWeek)
{
    Console.WriteLine(day);
}

// 
int[] numbers = { 1, 6, 8, 0, 5 };
int sum = 0;
foreach (int number in numbers)
{
    sum += number;
}
Console.WriteLine("The sum of the numbers is:" + sum);
