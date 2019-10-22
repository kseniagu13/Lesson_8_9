using System;

namespace IDCodeReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string id;
            bool idValid;
            Console.WriteLine("Enter your ID code: ");
            id = Console.ReadLine();
            idValid = CheckIDLength(id);

            if (idValid) //kui idValid on true, kas on 11 tähemärki või mitte
            {
                Console.WriteLine("OK");
                GetGender(id);
                GetYear(id);
            }
            else //ei ole true
            {
                Console.WriteLine("not OK");
            }
            

            Console.ReadLine();
        }

        public static void GetGender(string idCode) //sugu, kas naine või mees
        {
            int firstNumber = int.Parse(idCode[0].ToString());
            if (firstNumber == 4 || firstNumber == 6 || firstNumber == 2)
            {
                Console.WriteLine("Hello, Madam!");
            }
            else
            {
                Console.WriteLine("Hello, Sir!");
            }
            
        }

        public static bool CheckIDLength(string idCode) // kontrollib kas 11 tähemärki või mitte
        {
            bool isValid;
            if (idCode.Length == 11)
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }
            return isValid; // tagastab seda väärtust
        }

        public static void GetYear(string idCode)
        {
            string year = idCode.Substring(1, 2);
            string fullYear = $"19{year}";
            Console.WriteLine($"Your year of birth is: {year} .");
        }
    }
}
