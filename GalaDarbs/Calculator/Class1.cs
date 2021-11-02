using System;
namespace Calculator
{
    public static class Operations
    { 
        // TODO: 2) Failu pārsaukt Operation un arī tāpat klases nosaukumu
        // TODO: 3) uztaisīt konstruktoru, kas nolasīs ievadīto tekstu piem.:"1 + 3"
        // TODO: 4) sadala ievadīto tekstu pa atstarpēm(sākumam būs vieglāk)
        // TODO: 5) nosaka 1 un 2 skaitli kā arī darbības veidu
        // TODO: 6) izpilda vēlamo darbību un atgriež rezultātu GalaDarbs.Program.cs
        // TODO: 7) pārsaukt GalaDarbs projektu par BasicCalculator
        // TODO: 7) pārsaukt Calculator projektu par Calculation
        // pēc tam turpināsim tālak

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
        }
        public static void Minus(int firtstNum, int secondNum)
        {
            int result = firtstNum - secondNum;
            Console.WriteLine($"A - B = {result}");

        }
        public static void Times(int firtstNum, int secondNum)
        {
            int result = firtstNum * secondNum;
            Console.WriteLine($"A * B = {result}");
        }
        public static void Divide(int firtstNum, int secondNum)
        {
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

