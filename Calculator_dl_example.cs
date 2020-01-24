using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_dl_example
{
    public class Calculator_dl
    {
        public int add(int operator1, int operator2)
        {
            checked{
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
