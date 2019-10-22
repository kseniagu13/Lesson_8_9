using System;

namespace Functions_Lesson9
{
    class Program
    {
        //Kirjuta programmi, mis küsib kas sa tuled või lähed? Vastavalt sellele, mida kasutaja vastab
        // kirjuta kas Hello või Goodbye
        static void Main(string[] args)
        {
            string answer;
            string answerGender;
            int yearOfBirth;
            int age;
            Console.WriteLine("Are you coming or leaving?");
            answer = Console.ReadLine();
            Console.WriteLine("What is your gender?");
            answerGender = Console.ReadLine();
            Console.WriteLine("What is your year of birth?");
            yearOfBirth = int.Parse(Console.ReadLine());
            age = 2019 - yearOfBirth;

            if (answer.ToLower() == "coming")
            {
                Hello(answer, answerGender, age);
            }

            else if (answer.ToLower() == "leaving")
            {
                Goodbye(answer, answerGender, age);
            }

            Console.ReadLine(); 
        }



        public static void Hello(string answer, string gender, int age) //võib jäta tühjad sulud ja siis vastused tulevad vt alla
        {
            if (gender.ToLower() == "female")
            {
                Console.WriteLine($"Hello Madam, you are {answer} . You  are {age} old."); // vastus siis tuleks lihtsalt Hello
            }
            else if (gender.ToLower() == "male")
            {
                Console.WriteLine($"Hello Sir, you are {answer} . You are {age} old."); // vastus siis tuleks lihtsalt Hello
            }
        }

        public static void Goodbye(string answer, string gender, int age)
        {
            if (gender.ToLower() == "female")
            {
                Console.WriteLine($"Goodbye Madam, you are {answer}. You are  {age} old. ");// või Goodbye
            }

            else if (gender.ToLower() == "male")
            {
                Console.WriteLine($"Goodbye Sir, you are {answer}. You are  {age} old. ");
            }
        }
        
    }
}