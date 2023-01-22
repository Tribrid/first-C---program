using System;

class Calculator
{
    static void Main(string[] args)
    {
        int age;
        Console.WriteLine("Enter your age");
        age =
        Convert.ToInt16(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine("You are old enough");
        }
        else if (age < 18)
        {
            Console.WriteLine("You are a kid");
        }
    }
        }
