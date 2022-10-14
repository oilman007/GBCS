/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

void Init(int[,] matrix, int min, int max)
{
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = rand.Next(min, max+1);
}

int[,] Mult(int[,] m1, int[,] m2)
{
    // https://ru.wikipedia.org/wiki/%D0%A3%D0%BC%D0%BD%D0%BE%D0%B6%D0%B5%D0%BD%D0%B8%D0%B5_%D0%BC%D0%B0%D1%82%D1%80%D0%B8%D1%86
    int m1_rows = m1.GetLength(0);
    int m1_cols = m1.GetLength(1);

    int m2_rows = m2.GetLength(0);
    int m2_cols = m2.GetLength(1);

    if(m1_cols != m2_rows)
        return new int[0,0];
    
    int [,] result = new int[m1_rows, m2_cols];

    for (int r = 0; r < m1_rows; r++)
    {        
        for (int c = 0; c < m2_cols; c++)
        {
            int sum = 0;
            for (int i = 0; i < m1_cols; i++)
            {
                sum += m1[r,i] * m2[i,c];
            }
            result[r, c] = sum;    
        }        
    }
    return result;
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
//Console.Write("Enter n-rows: ");
//int r1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter n-colomns: ");
//int c1 = Convert.ToInt32(Console.ReadLine());
//Init(m1, 1, 9);
int[,] m1 = new int[2, 2];
m1[0,0] = 2;
m1[0,1] = 4;
m1[1,0] = 3;
m1[1,1] = 2;
ShowMatrix(m1);

//Console.Write("Enter n-rows: ");
//int r2 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter n-colomns: ");
//int c2 = Convert.ToInt32(Console.ReadLine());
int[,] m2 = new int[2, 2];
//Init(m2, 1, 9);

m2[0,0] = 3;
m2[0,1] = 4;
m2[1,0] = 3;
m2[1,1] = 3;
ShowMatrix(m2);

ShowMatrix(Mult(m1,m2));
