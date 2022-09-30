/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Clear();
Console.Write("Enter 5 digit value: ");
string value = Console.ReadLine();
if(value[0] == value[4] && value[1] == value[3])
    Console.WriteLine("value is polyndrome");
else
    Console.WriteLine("value is not polyndrome");