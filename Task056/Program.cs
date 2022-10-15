/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

void Init(int[,] matrix, int min, int max)
{
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = rand.Next(min, max+1);
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + " \t");
        Console.WriteLine();
    }
    Console.WriteLine();
}



Console.Clear();
Console.Write("Enter n-rows: ");
int nrow = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter n-colomns: ");
int ncol = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[nrow, ncol];
Init(matrix, 1, 9);
ShowMatrix(matrix);
int result = 0;
int min = int.MaxValue;
for(int r=0; r< nrow; ++r)
{
    int[] temp = new int[ncol];
    for(int c = 0; c< ncol; ++c) temp[c] = matrix[r,c];
    int sum = temp.Sum();
    if(min > sum)
    {
        min = sum;
        result = r;
    }
}
Console.Write($"min row is #{result+1}");
