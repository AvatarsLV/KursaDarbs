using System;
using static Calculation.Calculation;

namespace GalaDarbs
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("***INT number calculator***");
            Console.WriteLine("*add space between elements*");
            Console.WriteLine(" ");
            Console.WriteLine("Input equation, available operations:");
            foreach (var opInEnum in Enum.GetValues(typeof(MathOperations)))
            {
                Console.WriteLine(opInEnum.ToString());
            }
            Console.WriteLine("**************");

            try
            {
                while (true)
                {
                    var result = GetUserInputResult();
                    Console.WriteLine($"={result}");
                    Console.WriteLine("Keep going:");
                }
            }

            catch (Exception)
            {
                Console.WriteLine("Oops...invalid expression!");
            }
        }
    }
}
