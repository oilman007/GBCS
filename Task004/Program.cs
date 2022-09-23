Console.WriteLine("Enter first value:");
int v1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second value:");
int v2 = int.Parse( Console.ReadLine());
Console.WriteLine("Enter third value:");
int v3 = int.Parse( Console.ReadLine());
Console.WriteLine($"Max = {Math.Max(Math.Max(v1, v2),v3)}");