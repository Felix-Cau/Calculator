using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Calculations
    {
        

        public static Result Add(double x, double y)
        {
            Result result = new();
            result.Value = x + y;
            return result;
        }
        
        public static Result Subtract(double x, double y)
        {
            Result result = new();
            result.Value = x - y;
            return result;
        }

        public static Result Multiply(double x, double y)
        {
            Result result = new();
            result.Value = x * y;
            return result;
        }

        public static Result Divide(double x, double y)
        {
            Result result = new();
            if (x == 0 || y == 0)
            {
                result.Message = MessageHandler.CantDivideByZero;
                return result;
            }
            result.Value = x / y;
            return result;
        }
    }
}
