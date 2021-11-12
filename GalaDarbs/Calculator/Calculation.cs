using System;

namespace Calculation
{
    public class Calculation : ICalculation
    {
        public static int numberOne { get; set; }
        public static int numberTwo { get; set; }
        public static MathOperations operation { get; set; }

        public static float GetUserInputResult()
        {
            float result = 0;
            string resultEquation = Console.ReadLine();

            string[] bText = resultEquation.Split(' ');
            int aNumber, bNumber;
            if (!int.TryParse(bText[0], out aNumber))
            {
                throw new Exception("Error: Number not detected.");
            }
            else if (!int.TryParse(bText[2], out bNumber))
            {
                throw new Exception("Error: Number not detected.");
            }

            string operationSign = bText[1];
            var operationString = GetOperation(operationSign);

            switch (operationString)
            {
                case MathOperations.Plus:
                    result = Sum(aNumber, bNumber);
                    break;
                case MathOperations.Minus:
                    result = Minus(aNumber, bNumber);
                    break;
                case MathOperations.Divide:
                    result = Divide(aNumber, bNumber);
                    break;
                case MathOperations.Times:
                    result = Times(aNumber, bNumber);
                    break;
            }

            return result;
        }


        float ICalculation.Sum(int firtstNum, int secondNum)
        {
            return Sum(firtstNum, secondNum);
        }
        float ICalculation.Minus(int firtstNum, int secondNum)
        {
            return Minus(firtstNum, secondNum);
        }
        float ICalculation.Times(int firtstNum, int secondNum)
        {
            return Times(firtstNum, secondNum);
        }
        float ICalculation.Divide(int firtstNum, int secondNum)
        {
            return Divide(firtstNum, secondNum);
        }

        public static float Sum(int firtstNum, int secondNum)
        {
            return firtstNum + secondNum;           
        }
        public static float Minus(int firtstNum, int secondNum)
        {
            return firtstNum - secondNum;
        }
        public static float Times(int firtstNum, int secondNum)
        {
            return firtstNum * secondNum;
        }
        public static float Divide(int firtstNum, int secondNum)
        {
            if (secondNum == 0)
            {
                throw new Exception("You cannot divide with 0");
            }

            return firtstNum / secondNum;
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
            switch (text)
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
                    throw new Exception();
            }
        }
    }
}
