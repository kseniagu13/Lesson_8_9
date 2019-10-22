using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {

            // DRY
            // Do not
            //repeat
            //yourself  funktsioon kui tahad mingit asja mitu korda teha

            /*int a = 5;
            int b = 5;
            int c = a + b;
            Console.WriteLine($"Resul from Main {c}");
            Sum(a, b);
            Sum(10, 20);
            Hello();*/

            GreetByName("Ksenia");

            Console.ReadLine();
        }
        // static tähendab, et me võime kasutada seda ilma klassideta, ei pea olema objekti
        // void - tähendab, tühjust.
        // Sum paneme nimeks Sum ja suure tähega!

        public static void Sum(int x, int y)
        {
            Console.WriteLine($"Result is {x + y}");
        }

        public static void Hello() // kirjutame funktsiooni mis tervitab meid
        {
            Console.WriteLine("Hello");

        }

        public static void GreetByName(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
       
    }
}
