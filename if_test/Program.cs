using System;
namespace if_test
{
    internal class IfElse
    {
        int number = 5;
        int number2 = 1;
        bool isEqual = false;

        public void run()
        {
            if (number == number2)
            {
                isEqual = true;
                Console.WriteLine("numbers are equal");
            }
            else
            {
                isEqual = false;
                Console.WriteLine("numbers are not equal");
            }
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            IfElse ifElse = new IfElse();
            ifElse.run();
        }
    }
}