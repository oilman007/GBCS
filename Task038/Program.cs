/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

void InputArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max+1);
}

int Min(int [] array)
{
    int result = array[0];
    for (int i = 1; i < array.Length; i++)
            if(result > array[i])
                result = array[i];
    return result;
}

int Max(int [] array)
{
    int result = array[0];
    for (int i = 1; i < array.Length; i++)
            if(result < array[i])
                result = array[i];
    return result;
}

Console.Clear();
Console.Write("Enter array length: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array, 1, 9);
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine($"max - min = {Max(array)-Min(array)}");
