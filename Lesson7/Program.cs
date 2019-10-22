using System;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {


            /*TASK 1 Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
            //Dispaly the numbers and the count on the console.
            int counter = 0;
            for (int i = 1; i <=100; i++)
            {
                if ( i % 3 == 0)
                {
                  counter++;
                }

             }

            Console.WriteLine($"{counter}"); */

            // TASK 2 Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number.

            // If the users gueses the numbers, display "You won"; otherwise, display "You lost".
            // while ga saad lõpmatuseni tehteid teha ja for-ga ise paned kirja palju

            
            bool gameOver = false;
            int userChance = 0;

            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 11); //1 on kaasaarvatud ja 11 tähendab 10 kaasaarvatud!

            while (!gameOver) //not gameover on true
            {
                Console.WriteLine($"Choose your number from 1-10 ");
                int userNumber = Int32.Parse(Console.ReadLine());
                Console.WriteLine(randomNumber); // kui tahan kontrollida kas random number on sama koguaeg siis peab olema whilest väljas
                if (userNumber == randomNumber)
                {
                    Console.WriteLine($"You won!");
                    gameOver = true;
                }
                else
                {
                    Console.WriteLine($"Try Again");
                    userChance++;
                }


                if (userChance == 4) // kui user saab 4 katseid täis ta kaotab mängu
                {
                    Console.WriteLine($"Ops! You lost! random number was {randomNumber}");
                }
            }

            Console.ReadLine();


        }
    }
}
