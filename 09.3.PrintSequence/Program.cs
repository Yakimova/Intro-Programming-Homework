using System;
/*
    Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
 */
class PrintSequence
{
    static void Main()
    {
        int i = 2;
        Console.WriteLine(i + ", " + (-(i + 1)) + ", " + (i + 2) + ", " + (-(i + 3)) + ", " + (i + 4) + ", " + (-(i + 5)) + ", " + (i + 6) + ", " + (-(i + 7)) + ", " + (i + 8) + ", " + (-(i + 9)));
    }
}

