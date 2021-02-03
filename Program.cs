using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");

            string name = Console.ReadLine();

            Display_Name(name);
        }
        
        private static void Display_Name(string name)
        {
            Console.WriteLine("Hello " + name + "!");
        }    
    }
}
