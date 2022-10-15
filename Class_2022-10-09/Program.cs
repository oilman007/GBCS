/*
Задача 59: Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
*/

int[,] RemoveMin(int[,] matrix)
{
    int imin=0, jmin=0;
    int min = matrix[0,0];
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            if(min > matrix[i,j])
            {
                min = matrix[i,j];
                imin = i;
                jmin = j;
            }    
    int[,] result = new int[matrix.GetLength(0)-1, matrix.GetLength(1)-1];
    for (int i = 0, ii = 0; i < matrix.GetLength(0); i++)
    {
        if(i != imin)
        {
            for (int j = 0, jj = 0; j < matrix.GetLength(1); j++)
            {
                if(j != jmin)
                {
                    result[ii,jj] = matrix[i,j];
                    jj++;
                }
            }
            ii++;
        }
    }
    return result;
}

void Init(int[,] matrix)
{
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = rand.Next(1, 9);
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
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    Console.WriteLine();
}

int[] ToArray(int[,] matrix)
{
    int[] result = new int[ matrix.GetLength(0)* matrix.GetLength(1)];
    int r=0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[r++] = matrix[i,j];
        }        
    }
    return result;
}

void Sort(int[] array)
{
    int indx; //переменная для хранения индекса минимального элемента массива
    for (int i = 0; i < array.Length; i++) //проходим по массиву с начала и до конца
    {
        indx = i; //считаем, что минимальный элемент имеет текущий индекс 
        for (int j = i; j < array.Length; j++) //ищем минимальный элемент в неотсортированной части
        {
            if (array[j] < array[indx])
            {
                indx = j; //нашли в массиве число меньше, чем intArray[indx] - запоминаем его индекс в массиве
            }
        }
        if (array[indx] == array[i]) //если минимальный элемент равен текущему значению - ничего не меняем
            continue;
        //меняем местами минимальный элемент и первый в неотсортированной части
        int temp = array[i]; //временная переменная, чтобы не потерять значение intArray[i]
        array[i] = array[indx];
        array[indx] = temp;
    }
}

int GetCount(int value, int[] array, ref int start)
{
    int result = 0;
    for (int i = start; i < array.Length; i++)
        if(array[i] == value)
        {
            result++;
            start=i+1;
        }            
    return result;
}


Console.Clear();
Console.Write("Enter n rows: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter n colomns: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
Init(matrix);
ShowMatrix(matrix);
int[,] new_matrix = RemoveMin(matrix);
ShowMatrix(new_matrix);

