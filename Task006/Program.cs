Console.WriteLine("Enter value:");
int v = int.Parse(Console.ReadLine());

string ans = v%2 == 0 ? "even" : "odd";
Console.WriteLine($"Value is " + ans);