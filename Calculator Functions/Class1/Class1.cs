using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Functions.Class1
{
    internal class Class1
    {
        public int Num1;
        public int Num2;
        public int Num3;

       
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        
        public int Add(int number1, int number2, int number3)
        {
            return number1 + number2 + number3;
        }

        
        public double Add(int number1, int number2, double number3)
        {
            return number1 + number2 + number3;
        }

        
        public double Salary(double TheSalary, int Hours)
        {
            double TheRate = 10;
            return TheSalary + (Hours * TheRate);
        }
    }
}
    

