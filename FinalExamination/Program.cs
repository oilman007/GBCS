/*
написать программу, которая из имеющегося массива строк формирует
массив из строк, длина которых меньше или равно 3 символа. Первоночальный
массив можно ввести с клавиатуры или задать на старте выполнения алгоритма.
При решениии не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.
*/


Console.Write("Enter strings (separated by a space): ");
string values = Console.ReadLine();

string[] split = values.Split(' ', System.StringSplitOptions.RemoveEmptyEntries);

for(int i =0; i<split.Length; ++i)
    if(split[i].Length <= 3)
        Console.Write(split[i]) + " ";