/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

void InputArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max+1);
}

int SumOddIndecies(int [] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i+=2)
            result += array[i];
    return result;
}


Console.Clear();
Console.Write("Enter array length: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array, 1, 9);
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine($"sum of the odd indecias is {SumOddIndecies(array)}");
