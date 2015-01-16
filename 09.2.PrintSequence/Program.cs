using System;
/*
    Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
 */
class PrintSequence
{
    static void Main()
    {
        for (int i = 2; i < 12; i += 2) // i grows by 2, not by 1
        {

            Console.Write(i + ", "); // i is always even
            Console.Write(-(i + 1)); // i+1 is odd, so it has to be negative
            if (i < 10) // I don't want to have a ", " after my last number
                Console.Write(", "); 
        }
        Console.WriteLine(); // to put "Press any key to continue..." on a next line
    }
}

