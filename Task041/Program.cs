/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Clear();

Console.Write("Enter values (separated by a space): ");
string values = Console.ReadLine();

string[] split = values.Split(' ', System.StringSplitOptions.RemoveEmptyEntries);

double[] array = new double[split.Length];

for(int i=0;i<array.Length; ++i)
    array[i] = double.Parse(split[i]);

int result = 0;
for(int i=0;i<array.Length; ++i)
    if(array[i]>0)
        result++;

Console.WriteLine($"the quantity of numbers greater than zero is {result}");

