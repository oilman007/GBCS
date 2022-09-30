Console.Clear();

Console.Write("Enter N value: ");
int n = int.Parse(Console.ReadLine());

for(int i = 1; i<=n; ++i)
    Console.Write($"{i*i*i} ");
