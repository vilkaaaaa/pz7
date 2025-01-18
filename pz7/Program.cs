namespace pz7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EventLogger eventLogger = new EventLogger();
            Calculator calculator = new Calculator();
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            var action = Console.ReadKey();
            Console.WriteLine();
            double res = 0;
            switch (action.KeyChar)
            {

                case '+':
                    res = calculator.Add(a, b);
                    Console.WriteLine(res);
                    eventLogger.Log($"Сложение {a} {b}, результат: {res}");
                    break;
                    case '-':
                    res = calculator.Sub(a, b);
                    Console.WriteLine(res);
                    eventLogger.Log($"Вычитание {a} {b}, результат: {res}");

                    break;
                case '*':
                    res = calculator.Mul(a, b);
                    Console.WriteLine(res);
                    eventLogger.Log($"Умножение {a} {b}, результат: {res}");
                    break;
                    case '/':
                     res = calculator.Divi(a, b);
                    Console.WriteLine(res);
                    eventLogger.Log($"Деление {a} {b}, результат: {res}");
                    break;
            }
        }
    }
}