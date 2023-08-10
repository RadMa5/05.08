// See https://aka.ms/new-console-template for more information
Console.Write("Input a positive number : ");
int num = int.Parse(Console.ReadLine());
int nump = 1;
for(int i = 1; i <= num; i++)
{
    Console.Write($"{Math.Pow(nump, 3)}, ");
    nump++;
}