using System;
/*
 Write a program to read your birthday from the console atodayDay print how old you are now atodayDay how old you will be after 10 years.
 */
class CurrentDateAtodayDayTime
{
    static void Main()
    {
        int todayYear = DateTime.Today.Year;

        Console.Write("Please enter the year, when you were born: ");
        int birthYear = int.Parse(Console.ReadLine());
        while (birthYear < (todayYear - 150) || birthYear > todayYear) // nobody is older than 150 years atodayDay younger than 0
        {
            Console.Write("And now the real one: "); // if somebody tries impossible year it will make them try again
            birthYear = int.Parse(Console.ReadLine());
        }

        Console.Write("Please enter the month, when you were born: ");
        int birthMonth = int.Parse(Console.ReadLine());
        while (birthMonth < 1 || birthMonth > 12) // a year has only 12 months
        {
            Console.Write("And now the real one: "); // if somebody tries impossible month it will make them try again
            birthMonth = int.Parse(Console.ReadLine());
        }

        Console.Write("Please enter the day, when you were born: ");
        int birthDay = int.Parse(Console.ReadLine());
        while (birthDay < 1 || birthDay > 31) // a month can only have 31 days
        {
            Console.Write("And now the real one: "); // if somebody tries impossible day it will make them try again
            birthDay = int.Parse(Console.ReadLine());
        }

        int years = todayYear - birthYear;
        int todayMonth = DateTime.Today.Month;
        int todayDay = DateTime.Today.Day;

        if (birthMonth < todayMonth) // if the month of your birthday has passed, the you are already at this age
        {
            Console.WriteLine("Now you are " + years + " years old.");
            Console.WriteLine("In 10 years you will be " + (years + 10) + " years old.");
        }

        if (birthMonth == todayMonth) // if your bith month is now, the you could be or could not be yet at this age
        {
            if (birthDay < todayDay) // if your birthday has passed then you are at this age already
            {
                Console.WriteLine("Now you are " + years + " years old.");
                Console.WriteLine("In 10 years you will be " + (years + 10) + " years old.");
            }
            if (birthDay == todayDay) // it's your birthday
            {
                Console.WriteLine("Happy birtday! Today you are becoming " + years + " years old.");
                Console.WriteLine("In 10 years you will be " + (years + 10) + " years old.");
            }
            if (birthDay > todayDay) // your birthday is yet to come, so you are not yet at that age, so you are years-1 years old
            {
                Console.WriteLine("Now you are " + (years - 1) + " years old.");
                Console.WriteLine("In 10 years you will be " + (years + 9) + " years old.");
            }
        }

        if (birthMonth > todayMonth) // if your birth month hasn't come yet, then you are still years-1 years old
        {
            Console.WriteLine("Now you are " + (years - 1) + " years old.");
            Console.WriteLine("In 10 years you will be " + (years + 9) + " years old.");
        }

    }
}
