using System;
/*
    Create a console application that calculates and prints the square root of the number 12345.
    Find in Internet “how to calculate square root in C#”.

 */
class SquareRoot
{
    static void Main()
    {
        double s; // since the square root of 12345 is not a nice integer
        s = Math.Sqrt(12345);
        Console.Write("The square root of 12345 is ");
        Console.WriteLine(s);
    }
}

