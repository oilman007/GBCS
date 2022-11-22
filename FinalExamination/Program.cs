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


string temp = string.Empty;
for(int i =0; i<split.Length; ++i)
    if(split[i].Length <= 3)
        temp += split[i] + " ";

string[] result = temp.Split(' ', System.StringSplitOptions.RemoveEmptyEntries);

for(int i =0; i<result.Length; ++i)
    Console.Write($"{result[i]} ");