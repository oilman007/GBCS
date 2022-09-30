Console.Clear();

Console.Write("Enter A point coord (x y z): ");
string a_coord = Console.ReadLine();

Console.Write("Enter B point coord (x y z): ");
string b_coord = Console.ReadLine();

string[] a_split = a_coord.Split(' ', System.StringSplitOptions.RemoveEmptyEntries);
string[] b_split = b_coord.Split(' ', System.StringSplitOptions.RemoveEmptyEntries);

double xa = double.Parse(a_split[0]);
double ya = double.Parse(a_split[1]);
double za = double.Parse(a_split[2]);

double xb = double.Parse(a_split[0]);
double yb = double.Parse(b_split[1]);
double zb = double.Parse(b_split[2]);

double x = xa-xb;
double y = ya-yb;
double z = za-zb;

double distance = Math.Sqrt(x*x+y*y+z*z);

Console.Write($"Distance from A to B is equals: {distance}");