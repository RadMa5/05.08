// See https://aka.ms/new-console-template for more information
Console.Write("Input XA : ");
int xa = int.Parse(Console.ReadLine());

Console.Write("Input YA : ");
int ya = int.Parse(Console.ReadLine());

Console.Write("Input ZA : ");
int za = int.Parse(Console.ReadLine());

Console.Write("Input XB : ");
int xb = int.Parse(Console.ReadLine());

Console.Write("Input YB : ");
int yb = int.Parse(Console.ReadLine());

Console.Write("Input ZB : ");
int zb = int.Parse(Console.ReadLine());

double ab = Math.Sqrt(Math.Pow(xb - xa,2) + Math.Pow(yb - ya,2) + Math.Pow(zb - za,2));
Console.WriteLine($"Distance between two points is equal {ab}");