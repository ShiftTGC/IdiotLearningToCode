using System;

namespace IdiotLearningToCode
{
    class Program
    {
        static void Main(string[] args)
        {
            /* use this space to write your own short program! 
            Here's what you learned:

            DATA TYPES: int, double, char, string, bool
            VARIABLES: datatype variableName = value;
            COMMON ERRORS: wrong type, wrong value, no semicolon
            DATA TYPE CONVERSION: implicit, explicit, methods

            Good luck! */
            
            string correct = "World";
            Console.WriteLine("Hello ");
            string input = Console.ReadLine();

            if (input.ToUpper() == correct.ToUpper())
                Console.WriteLine("A man of culture I see");
            else
                Console.WriteLine("... Idiot");


                //if Console.ReadLine(correct) do:
                //    Console.WriteLine("A man of culture I see")
                //else
                //    Console.WriteLine("... Idiot")
        }
    }
}
