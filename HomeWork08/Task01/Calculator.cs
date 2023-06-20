using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork08.Task01
{
    public static class Calculator
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Divisor cannot be zero " + nameof(b));
            }
            return a / b;
        }

        public static double Pow(double a, int b)
        {
            double result = 1.00;
            if (b == 0)
            {
                return result;
            }
            else if (b > 0)
            {
                result = a;
                for (int i = 0; i < b; i++)
                {
                    result *= a;
                }
            }
            else
            {
                for (int i = 0; i < b; ++i)
                {
                    result /= a;
                }
            }
            return result;
        }

        public static double Sqrt(double a)
        {
            if (a == 0)
            {
                return 0;
            }

            double result = a / 2;
            double newResult = result;
            double diff = Math.Abs(a - result * result);
            if( a > 0)
            {
                
                while (diff > 0.00001)
                {
                    if (result * result > a)
                    {
                        newResult = result;
                        result /= 2;

                    }
                    if (result * result < a)
                    {
                        result = (result + newResult) / 2;
                    }
                    diff = Math.Abs(a - result * result);
                }
            }
            if( a < 0 )
            {
                throw new ArgumentException("You should enter only positive number");
            }
            return result;

        }
    }

}
