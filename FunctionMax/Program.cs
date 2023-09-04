// See https://aka.ms/new-console-template for more information

Console.WriteLine("Part 1\n");

Console.WriteLine("Enter the first number: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
int y = Convert.ToInt32(Console.ReadLine());

int c = Math.Max(x, y);
Console.WriteLine("The greater of {0} and {1} is {2}", x, y, c);





Console.ReadKey();
