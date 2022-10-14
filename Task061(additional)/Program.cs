

Console.Clear();
int[][] PascalsTriangle(int nrow)
{
    int[][] result = new int[nrow+1][];
    for(int i=0; i<=nrow; ++i)
    {
        int[] values = new int[i+1];
        values[0] = 1;
        values[i] = 1;
        for(int j = 1; j < i; ++j)
            values[j] = result[i-1][j-1] + result[i-1][j];
        result[i] = values;
    }
    Console.WriteLine("Pascals Triangle done");
    return result;
}

void PrintPascalsTriangle(int[][] triangle)
{
    int nrow = triangle.Length;
    int max_char = MaxChar(triangle.Last());
    int max_char_line = (max_char + 1)*nrow + 1;   
    int ipad = nrow.ToString().Length;
    for(int i=0; i<nrow; ++i)
    {
        string line = i.ToString().PadLeft(ipad) + ":" + new string(' ', (max_char_line - (max_char + 1)*triangle[i].Length)/2);
        for(int j=0; j<triangle[i].Length; ++j)
        {
            line += " " + triangle[i][j].ToString().PadLeft(max_char);
        }
        Console.WriteLine(line);
    }
}

int MaxChar(int[] array)
{
    int max = array[0];
    for(int i=1; i<array.Length; ++i)
        if(max < array[i])
            max = array[i];
    return max.ToString().Length;
}



Console.Write("Enter n rows: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintPascalsTriangle(PascalsTriangle(n));



