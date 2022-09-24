Console.Clear();
Console.Write("Введите облать 1,2,3 или 4: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x == 1)
    Console.WriteLine("+x,+yI");
else if (x == 2)
    Console.WriteLine("+x, -y");
else if (x == 3)
    Console.WriteLine("-x, -y");
else if (x == 4)
    Console.WriteLine("-x, +y");
