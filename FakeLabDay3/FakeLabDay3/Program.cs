using System;

namespace FakeLabDay3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CustomReverse("revan"));
            Console.WriteLine(CustomPower(5, 2));
            Console.WriteLine(SumDivide(17,15,3));
        }

        //Task 1
        public static string CustomReverse(string text)
        {
            string newText = "";
            // "" yerinə String.Empty yazmaq dah best case di
            for (int i = text.Length - 1; i >= 0; i--)
            {
                newText += text[i];
            }
            return newText;
        }
        //Task 2 
        public static int CustomPower(int number, int power)
        {
            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;
        }
        //Task 3
        public static int SumDivide(int minNumber, int maxNumber, int divided)
        {
            int total = 0;
            for (int i = minNumber; i <= maxNumber; i++)
            {
                if (IsDivide(i, divided))
                {
                    total += i;
                }
            }
            return total;
        }
        public static bool IsDivide(int number, int divided)
        {
            if (number % divided == 0)
            {
                return true;
            }
            return false;
        }
    }
}
