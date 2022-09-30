/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

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