using System;
namespace Calculator
{
    public static class Operations
    { 
        public static void Sum(int firtstNum, int secondNum)
        {
            int result = firtstNum + secondNum;
            Console.WriteLine($"A + B = {result}");
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

