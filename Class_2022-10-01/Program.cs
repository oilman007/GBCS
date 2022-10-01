Console.Clear();
void InputArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max+1);
}
int [] MultsArray(int [] array)
{
    int n = array.Length/2 + array.Length%2;
    int [] result = new int[n];
    for(int i=0; i<n;++i)
        result[i] = array[i] * array[array.Length - 1 - i];
    return result;
}
Console.Write("Enter array length: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array, 1, 9);
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine("[" + string.Join(", ", MultsArray(array)) + "]");
