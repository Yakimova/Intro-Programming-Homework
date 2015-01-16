using System;
/*
    Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
 */
class PrintSequence
{
    static void Main()
    {
        for (int i = 2; i < 12; i++)
        {
            if (i % 2 == 0)
                Console.Write(i); // the even numbers are possitive
            else
                Console.Write(-i); // the odd numbers are negative
            if (i<11) // I don't want to have a ", " after my last number
                Console.Write(", ");
        }
        Console.WriteLine(); // to put "Press any key to continue..." on a next line
    }
}

