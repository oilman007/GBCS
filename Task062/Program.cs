/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

void Init(int[,] matrix, int min, int max)
{
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = rand.Next(min, max+1);
}

void Spiral(int value, int imin, int imax, int jmin, int jmax, int[,] matrix)
{
    int init_value = value;
    for (int i = imin; i <= imax; i++)
        matrix[i, jmin] = value++;

    for (int j = jmin+1; j <= jmax; j++)
        matrix[imax, j] = value++;

    for (int i = imax-1; i >= imin; i--)
        matrix[i, jmax] = value++;

    for (int j = jmax-1; j > jmin; j--)
        matrix[imin, j] = value++;    

    if(init_value != value)
        Spiral(value, imin+1, imax-1, jmin+1, jmax-1, matrix);
}

void ShowMatrix(int[,] matrix)
{ 
    for (int j = 0; j < matrix.GetLength(1); j++)    
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
            Console.Write(matrix[i, j] + " \t");
        Console.WriteLine();
    }
    Console.WriteLine();
}



Console.Clear();
Console.Write("Enter dx: ");
int dx = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter dy: ");
int dy = Convert.ToInt32(Console.ReadLine());
int[,] m = new int[dx, dy];
Spiral(1, 0, dx-1, 0, dy-1, m);
ShowMatrix(m);
