Console.Clear();
Console.Write("Enter 5 digit value: ");
string value = Console.ReadLine();
if(value[0] == value[4] && value[1] == value[3])
    Console.WriteLine("value is polyndrome");
else
    Console.WriteLine("value is not polyndrome");