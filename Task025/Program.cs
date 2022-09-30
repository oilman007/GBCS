Console.Clear();

Console.Write("Enter value: ");
double value = double.Parse(Console.ReadLine());

Console.Write("Enter power: ");
double power = double.Parse(Console.ReadLine());

Console.Write($"Result: {Math.Pow(value, power)}");