using System;
using Calculator;

namespace GalaDarbs
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // TODO: 1) no šīs vietas tiek saukts Calculator, kas arī visu funkcionalitāti izdarīt un beigās atgriezīs ciparu
            // ieglabā mainīgajā rezultātu un to "WriteLaino"
            //piemēram: var result = Calculator.GetResult();
            Console.WriteLine("Ievadi A"); // TODO: 0) Nav kļūda, bet taisam programmu eng valodā arī koncoles tekstu
            string aText = Console.ReadLine();
            int aNumber = int.Parse(aText);
            Console.WriteLine($"A ir {aNumber}");

            // --------------------------------------------------------------------

            Console.WriteLine("Ievadi B");
            string bText = Console.ReadLine();
            int bNumber = int.Parse(bText);

            // --------------------------------------------------------------------

            int plus = aNumber + bNumber;  //Sum(aNumber,bNumber);
            int minus = aNumber - bNumber; //Minus(aNumber,bNumber);
            int times = aNumber * bNumber; //Times(aNumber,bNumber);
            int divide = aNumber / bNumber;//Divide(aNumber,bNumber);

            // --------------------------------------------------------------------

            Operations.Sum(aNumber, bNumber);
            Operations.Minus(aNumber, bNumber);
            Operations.Times(aNumber, bNumber);
            Operations.Divide(aNumber, bNumber);
        }
    }
}
