/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

void InputArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max+1);
}

int EvenNumber(int [] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
        if(array[i]%2==0)
            result++;
    return result;
}


Console.Clear();
Console.Write("Enter array length: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array, 100, 999);
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine($"number of even is {EvenNumber(array)}");
