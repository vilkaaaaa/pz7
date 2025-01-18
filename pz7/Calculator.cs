using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz7
{
    public class Calculator
    {
        public delegate void OnCalculationPerformed(string message);
        public event OnCalculationPerformed Notify;
        void Message()
        {
            Console.WriteLine("Произошла операция");
        }
        public double Add(double a, double b)
        {
            //Notify?.Invoke("Произошло сложение");
            return a + b;
        }
        public double Sub(double a, double b)
        {
            return a - b;
        }
        public double Mul(double a, double b)
        {
            return a * b;
        }
        public double Divi(double a, double b)
        {
            if (b == 0 || a == 0 || a == 0 & b == 0)
            {
                Console.WriteLine("деление на 0 - ошибка");
                return 0;
            }
            else
            {
                return Math.Round(a / b, 3);
            }

        }
    }
}
