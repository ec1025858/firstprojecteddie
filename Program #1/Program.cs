// See https://aka.ms/new-console-template for more information
Console.WriteLine("What's your first name?");
var F = Console.ReadLine();
Console.WriteLine("What's your last name?");
var L = Console.ReadLine();
Console.WriteLine($"Greetings {F} {L}!");
//The code asks the user their name, then greets them.
Console.WriteLine("Type a number.");
string x = Console.ReadLine() + "";
int X = Convert.ToInt32(x);
Console.WriteLine("Type another number.");
string y = Console.ReadLine() + "";
int Y = Convert.ToInt32(y);
Console.WriteLine("Type in one last number");
string z = Console.ReadLine() + "";
int Z = Convert.ToInt32(z);
//The code asks the user to type three different numbers.
int a = X + Y + Z;
Console.WriteLine(a);
Console.WriteLine("" + (Y - X));
int b = X * Z;
Console.WriteLine("" + (a / Y));
Console.WriteLine("" + (X % b));
//The code uses the numbers that it asked user for to do a series of equations.
