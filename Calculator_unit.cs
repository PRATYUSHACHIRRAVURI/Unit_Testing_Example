using System;

namespace Calculator
{
    public class Calculator1

    {

        public static void Main()

        {
            int first_number;

            int second_number;

            string operate;

            float result;

            Console.Write("Please enter the first integer: ");

            first_number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the second integer: ");

            second_number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter an operator (+, -, /, *): ");

            Calculator1 c = new Calculator1();
            operate = Console.ReadLine();
            switch (operate)

            {
                case "-":

                    result = c.subtract(first_number, second_number);

                    break;

                case "+":

                    result = c.add(first_number, second_number);

                    break;

                case "/":

                    result = c.divide(first_number, second_number);

                    break;

                case "*":

                    result = c.multiply(first_number, second_number);

                    break;

                default:

                    result = 0;

                    break;

            }

            Console.WriteLine(first_number.ToString() + " " + operate + " " + second_number.ToString() + " = " + result.ToString());

        }

       public int add(int operator1, int operator2)
       {
           checked
        { 
           return operator1 + operator2;
        }
        }

       public int subtract(int operator1, int operator2)
        {
           checked{
            return operator1 - operator2;
        }
       }

       public int multiply(int operator1, int operator2)
        {
           checked{
            return operator1 * operator2;
        }
       }

        public int divide(int operator1, int operator2)
        {
            if (operator2 == 0)
                throw new System.DivideByZeroException();
            else
            return operator1 / operator2;
        }

    }
}
