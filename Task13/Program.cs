Console.WriteLine("Enter value:");
string s = Console.ReadLine();
if(s.Length < 3)
    Console.WriteLine("is not a three-digit value");
else
    Console.WriteLine(s[2]);