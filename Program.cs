using System;

namespace Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an interger between 1 and 100");

            try
            {
                string input = Console.ReadLine();

                int a = int.Parse(input); //setting up varibles for while loops
                int b = 1; //throw away variable to create a baseliine 
                while( b <= a)
                {

                    Console.WriteLine("You have entered "+ a + "This is the current integer value in the loop: " + b);
                    b++;
                }
            }

            catch
            {//just in case someone mistypes the input
                Console.WriteLine("Please input a valid interger");
            }
        }
    }
}
