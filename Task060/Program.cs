/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

void InitCube(int[,,] cube, int min, int max)
{
    Random rand = new Random();
    for (int i = 0; i < cube.GetLength(0); i++)
        for (int j = 0; j < cube.GetLength(1); j++)
            for (int k = 0; k < cube.GetLength(2); k++)
                cube[i, j, k] = rand.Next(min, max+1);
}

void ShowCube(int[,,] cube)
{
    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)
                Console.Write($"{cube[i,j,k]}({i},{j},{k})\t");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}



Console.Clear();
Console.Write("Enter dx: ");
int dx = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter dy: ");
int dy = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter dz: ");
int dz = Convert.ToInt32(Console.ReadLine());

int[,,] cube = new int[dx,dy,dz];
InitCube(cube, 10, 99);
ShowCube(cube);

