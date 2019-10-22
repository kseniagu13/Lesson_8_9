using System;

namespace MyFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string colour;
            Console.WriteLine("Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Colour: ");
            colour = Console.ReadLine();
            KnowMe(name, colour); //kui on antud kaks parameetri siis pead kindlasti siia kahte kutsuma
            
        }

        public static void KnowMe(string name, string colour)
        {
            Console.WriteLine($"Hello, {name}. Your favourite colour is {colour}.");

        }

        
    }
}
