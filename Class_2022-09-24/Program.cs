Console.Clear();
Console.Write("Enter value:");
int n = int.Parse(Console.ReadLine());

string result = string.Empty;
for(int i=0; i<n; i++)
    result += $"{(i+1)*(i+1)} ";

Console.WriteLine(result);