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

        public double Add(double a, double b)
        {
            double result = a + b;
            Notify?.Invoke($"Произошло сложение: {a} + {b} = {result}");
            return result;
        }

        public double Sub(double a, double b)
        {
            double result = a - b;
            Notify?.Invoke($"Произошло вычитание: {a} - {b} = {result}");
            return result;
        }

        public double Mul(double a, double b)
        {
            double result = a * b;
            Notify?.Invoke($"Произошло умножение: {a} * {b} = {result}");
            return result;
        }

        public double Divi(double a, double b)
        {
            if (b == 0 || a == 0 || a == 0 && b == 0)
            {
                Console.WriteLine("Деление на 0 - ошибка");
                Notify?.Invoke("Ошибка: деление на 0");
                return 0;
            }
            else
            {
                double result = Math.Round(a / b, 3);
                Notify?.Invoke($"Произошло деление: {a} / {b} = {result}");
                return result;
            }
        }
    }
}
