using System;
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



        public static void Sum(int firtstNum, int secondNum)
        {
            
            int result = firtstNum + secondNum;
            
            Console.WriteLine($"A + B = {result}"); // returnot resultats
            //pakape logaritms
            // inline split
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
    }
}

