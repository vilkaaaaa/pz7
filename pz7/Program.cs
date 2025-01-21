namespace pz7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EventLogger eventLogger = new EventLogger();
            Calculator calculator = new Calculator();
            calculator.Notify += eventLogger.Log;
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
                    break;
                    case '-':
                    res = calculator.Sub(a, b);
                    Console.WriteLine(res);
                    break;
                case '*':
                    res = calculator.Mul(a, b);
                    Console.WriteLine(res);
                    break;
                    case '/':
                     res = calculator.Divi(a, b);
                    Console.WriteLine(res);
                    break;
            }
        }
    }
}