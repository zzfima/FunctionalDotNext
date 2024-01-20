using MathSharp;

Console.WriteLine("input 2 numbers");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"sum of {a} and {b} is {MathLogic.add(a, b)}");
Console.WriteLine($"minus of {a} and {b} is {SharpClient.minus(a, b)}");
Console.ReadLine();