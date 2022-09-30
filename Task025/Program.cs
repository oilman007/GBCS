/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Clear();

Console.Write("Enter value: ");
double value = double.Parse(Console.ReadLine());

Console.Write("Enter power: ");
double power = double.Parse(Console.ReadLine());

Console.Write($"Result: {Math.Pow(value, power)}");