/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

void Init(double[,] matrix)
{
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = rand.NextDouble()*10;
}

void ShowMatrix(double[,] matrix)
{ 
    for (int j = 0; j < matrix.GetLength(1); j++)    
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
            Console.Write(matrix[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}



Console.Clear();
Console.Write("Enter dx: ");
int dx = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter dy: ");
int dy = Convert.ToInt32(Console.ReadLine());
double[,] m = new double[dx, dy];
Init(m);
ShowMatrix(m);
