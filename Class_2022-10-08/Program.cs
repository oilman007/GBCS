Console.Clear();
void InitMatrix(int[,] matrix)
{
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = rand.Next(1, 9);
}

int SumDiagonal(int[,] matrix)
{
    int result = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            if(i == j)
                result += matrix[i, j];
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

Console.Write("Enter n rows: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter n colomns: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InitMatrix(matrix);
ShowMatrix(matrix);
Console.Write($"Sum diagonal = {SumDiagonal(matrix)}");

/*
for(int i = 0; i <= weight; i+=x )
    for(int j = 0; j <= weight-i; j+=y )
        for(int k = 0; k <= weight-i-j; k+=z )
            if(i+j+k == weight)
                count++;
*/