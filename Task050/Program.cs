/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Строка 1
Столбец 2
Вывод: 4
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

Init(m,1,9);
ShowMatrix(m);

Console.Write("Enter i: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter j: ");
int j = Convert.ToInt32(Console.ReadLine());

if (0<=i && i < dx &&
    0<=j && j < dy )
    Console.WriteLine(m[i,j]);
else
    Console.WriteLine("Index out of range");