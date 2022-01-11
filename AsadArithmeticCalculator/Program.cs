using System;

namespace AsadArithmeticCalculator
{
    class Program
    {
        public static int Addition(int firstNum, int secondNum)
        {
            int result = firstNum + secondNum;
            return result;
        }
        public static int Subtraction(int firstNum, int secondNum)
        {
            int result = firstNum - secondNum;
            return result;
        }
        public static int Multiplication(int firstNum, int secondNum)
        {
            int result = firstNum * secondNum;
            return result;
        }
        public static int Division(int firstNum, int secondNum)
        {
            int result = firstNum / secondNum;
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Press any following key to perform an arithmetic operation:");
            Console.WriteLine();
            Console.WriteLine("1 - Addition\n2 - Subtraction\n3 - Multipliation\n4 - Division");
            Console.WriteLine();
            int firtsNum;
            int secondNum;
            int result = 0;
            int action = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Value 1: ");
            firtsNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Value 2: ");
            secondNum = Convert.ToInt32(Console.ReadLine());

            switch (action)
            {
                case 1:
                    {
                        result = Addition(firtsNum, secondNum);
                        break;
                    }
                case 2:
                    {
                        result = Addition(firtsNum, secondNum);
                        break;
                    }
                case 3:
                    {
                        result = Addition(firtsNum, secondNum);
                        break;
                    }
                case 4:
                    {
                        result = Addition(firtsNum, secondNum);
                        break;
                    }
            }

            Console.WriteLine(result);
            Console.WriteLine();

            Console.WriteLine("Do you want to continue again (Y/N)?");
        }
    }
}
