/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

// задание не понял. Кто вводит значения? Если генерируются, то в каких пределах?
// Почему в примере показан массив из 5 и 3 значений?

// Сдалал, как понял: пользователь вводит N значений, программа создает из них массив и выводит на экран.

Console.Clear();

Console.Write("Enter values (separated by a space): ");
string values = Console.ReadLine();

string[] split = values.Split(' ', System.StringSplitOptions.RemoveEmptyEntries);

double[] array = new double[split.Length];

for(int i=0;i<array.Length; ++i)
    array[i] = double.Parse(split[i]);

Console.WriteLine("["+string.Join(',', array)+"]");

