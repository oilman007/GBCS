﻿/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

int Pow(int a, int b)
{    
    if(b == 0)
        return 1;
    return Pow(a, b-1) * a;
}


Console.Clear();
Console.Write("Enter A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{Pow(a,b)}");
