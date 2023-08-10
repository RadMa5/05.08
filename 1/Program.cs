

Console.Write("Input 5 digit number : ");
int num = int.Parse(Console.ReadLine());
int numa = num / 1000;
int numb = (num % 10)*10 + (num % 100)/10;
if (numa == numb) { Console.WriteLine("Given number is a palindrome"); }
else { Console.WriteLine("Given number isn't a palindrome"); }