using System;
using BasicCalculator;

namespace Calculator
{
    public static class Operations
    {
        // TODO: 2) FAILU pārsaukt Operation un arī tāpat KLASES nosaukumu
        // TODO: 3) uztaisīt KONSTRUKTORU, kas nolasīs ievadīto tekstu piem.:"1 + 3" TO KAS IR IEKŠ BASICCALCULATOR
        // TODO: šajā failā (un projektā) NEKUR netaisa writeline!!! tā vietā funkcijas atgriež rezultātu, tas izskatās šādi:
        /**
         * 1)šis klases konstruktorā ir darbības kas šobrīd atrodas iekā BasicCalculator
         * 2)šis konstruktors nosaka darbības veidu un izsauc attiecīgo funk, kas atgriež rezultātu
         * 3) beigās konstruktors atgirž gala rezultātu un BASICCALCULATOR saņemot šo rezultātu to uzraksta konsolē
         */
        //TODO: sakārtot pareizi visas darbību funkcijas (atgriež rezultātu)

        //unit tests minus operacijai

        public static Calculation GetUserInput()
        {
            string resultEquation = Console.ReadLine();
            string[] equationSplitet = resultEquation.Split(' ');

            string[] bText = resultEquation.Split(' ');
            int aNumber = Convert.ToInt32(bText[0]);


            

            var bNumber = int.Parse(bText[2]); // TODO: noķert kļūdu, ja ievadītais nav skaitlis
            string operationSign = bText[1];
            var Calculation = new Calculation
            {
                numberOne = aNumber,
                numberTwo = bNumber,
                operation = GetOperation(operationSign)

            };

            return Calculation;
        }


    public static void Sum(int firtstNum, int secondNum)
        {
            
            int result = firtstNum + secondNum;
            
            Console.WriteLine($"A + B = {result}"); // returnot resultats
            //pakape logaritms
            // ar iekavam
            //GD atdod calc ievadi un calc visu izdara un GD parada
            //enumi interfeisi
            //katrai darbibai ir sava klase kas atbilst vienam interfase
            //
            //
        }
        public static int Minus(int firtstNum, int secondNum)
        {
            int result = firtstNum - secondNum;
            return result;
        }
        public static void Times(int firtstNum, int secondNum)
        {
            int result = firtstNum * secondNum;
            Console.WriteLine($"A * B = {result}");
        }
        public static void Divide(int firtstNum, int secondNum)
        {
            if (secondNum == 0)
            {
                Console.WriteLine("You cannot divide with 0");
                return;
            }

            int result = firtstNum / secondNum;
            Console.WriteLine($"A / B = {result}");
            }

        public enum MathOperations
        {
            Plus,
            Minus,
            Times,
            Divide

        }

        public static MathOperations GetOperation(string text) 
        {
            switch (text) // TODO: noķert kļūdu, ja ievadītais nav valida operācija
            {
                case "+":
                    return MathOperations.Plus;

                case "-":
                    return MathOperations.Minus;

                case "/":
                    return MathOperations.Divide;

                case "*":
                    return MathOperations.Times;
                default:
                    throw new ArgumentOutOfRangeException();

            }
        }

    }
}

