using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        int sum = num1 + num2;
        Console.WriteLine("The sum of {0} and {1} is {2}", num1, num2, sum);

        Console.ReadKey();
    }
}