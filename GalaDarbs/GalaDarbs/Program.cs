using System;
using Calculator;
using static Calculator.Operations;

namespace GalaDarbs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input equation, available operations:");
            foreach (var opInEnum in Enum.GetValues(typeof(MathOperations)))
            {
                Console.WriteLine(opInEnum.ToString());
            }

            // TODO: No šejienes visam  jābūt iekš Calculation projekta
            string resultEquation = Console.ReadLine();
            string[] equationSplitet = resultEquation.Split(' ');
            
            string[] bText = resultEquation.Split(' ');
            //int aNumber = int.Parse(bText[0]);
            var aNumber = Convert.ToInt32(bText[0]); // TODO: noķert kļūdu, ja ievadītais nav skaitlis
            var bNumber = int.Parse(bText[2]); // TODO: noķert kļūdu, ja ievadītais nav skaitlis
            string operationSign = bText[1]; 


            switch (operationSign) // TODO: noķert kļūdu, ja ievadītais nav valida operācija
            {
                case "+" :
                    Operations.Sum(aNumber, bNumber);
                    break;

                case "-":
                    Operations.Minus(aNumber, bNumber);
                    break;

                case "/":
                    Operations.Divide(aNumber, bNumber);
                    break;

                case "*":
                    Operations.Times(aNumber, bNumber);
                    break;

            }
            // TODO: beigās šeit izvada iegūto rezultātu




            //Console.WriteLine($"A is {aNumber} and B is {bNumber} ,operation is {operationSign}");

            // --------------------------------------------------------------------

            //int num = (int)MathOperations.Divide;
            //Console.WriteLine($"Operation {(int)MathOperations.Divide} : {MathOperations.Divide}");
           

            // --------------------------------------------------------------------

            //int plus = aNumber + bNumber;  //Sum(aNumber,bNumber);
            //int minus = aNumber - bNumber; //Minus(aNumber,bNumber);
            //int times = aNumber * bNumber; //Times(aNumber,bNumber);
          


            // --------------------------------------------------------------------

            //Operations.Sum(aNumber, bNumber);

            //int minusResult = Operations.Minus(aNumber, bNumber);
            //Console.WriteLine($"A - B = {minusResult}");

            //Operations.Times(aNumber, bNumber);
            //Operations.Divide(aNumber, bNumber);
        }
    }
}
