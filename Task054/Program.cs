/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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
for(int r=0; r< nrow; ++r)
{
    int[] temp = new int[ncol];
    for(int c = 0; c< ncol; ++c) temp[c] = matrix[r,c];
    temp = temp.OrderBy(x=>x).Reverse().ToArray();
    for(int c = 0; c< ncol; ++c) matrix[r,c] = temp[c];
}
ShowMatrix(matrix);
