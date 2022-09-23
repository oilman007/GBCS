Console.WriteLine("Enter value:");
int n = int.Parse(Console.ReadLine());

string result = string.Empty;
for(int i=1; i<n; i+=2)
    result += $"{i+1} ";

Console.WriteLine(result);