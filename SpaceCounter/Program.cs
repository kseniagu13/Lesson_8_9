using System;

namespace SpaceCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string userSentence;
             Console.WriteLine("Enter your sentence: ");
             userSentence = Console.ReadLine();
             CountSpaces(userSentence);

         }

         public static void CountSpaces(string sentence)
         {
             int counter = 0;
             foreach (char symbol in sentence)
             {
                 if(symbol == ' ')
                 {
                     counter++;
                 }
             }
             Console.WriteLine($"There are {counter} spaces in your sentence.");
         }*/

            int yearOfBirth;
            Console.WriteLine("What is your year of birth?");
            yearOfBirth = int.Parse(Console.ReadLine());

            Age(yearOfBirth);
            Console.ReadLine();

        }

        public static void Age(int yearOfBirth)
        {
            Console.WriteLine($"You are {2019 - yearOfBirth} years old.");

        }
    }
}
