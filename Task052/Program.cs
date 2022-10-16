/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
    for (int j = 0; j < matrix.GetLength(1); j++)    
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
            Console.Write(matrix[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] AverColumn(int[,] matrix)
{
    double[] result = new double[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        result[i] = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[i] += matrix[i,j];
        }
        result[i] /= matrix.GetLength(1);
    }
    return result;
}


Console.Clear();
Console.Write("Enter dx: ");
int dx = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter dy: ");
int dy = Convert.ToInt32(Console.ReadLine());
int[,] m = new int[dx, dy];

Init(m,1,9);
ShowMatrix(m);

Console.WriteLine("Aver: " + string.Join("; ", AverColumn(m)));
