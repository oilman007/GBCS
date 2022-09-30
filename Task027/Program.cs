/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Clear();
Console.Write("Enter value: ");
string value = Console.ReadLine();

int result = 0;
for(int i=0; i< value.Length; ++i)
    result += int.Parse($"{value[i]}");

Console.WriteLine($"Sum: {result}");
