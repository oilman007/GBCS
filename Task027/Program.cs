Console.Clear();
Console.Write("Enter value: ");
string value = Console.ReadLine();

int result = 0;
for(int i=0; i< value.Length; ++i)
    result += int.Parse($"{value[i]}");

Console.WriteLine($"Sum: {result}");
