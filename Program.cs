using System;


delegate double CalcDelegate(double num1, double num2, char op);

class CalcProgram
{
    static double Calc(double num1, double num2, char op)
    {
        switch (op)
        {
            case '+':
                return num1 + num2;
            case '-':
                return num1 - num2;
            case '*':
                return num1 * num2;
            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Division by zero.");
                    return 0;
                }
                else
                {
                    return num1 / num2;
                }
            default:
                Console.WriteLine("Error: Invalid operator.");
                return 0;
        }
    }

    public static CalcDelegate funcCalc = new CalcDelegate(Calc);
}

class Program
{
    static void Main(string[] args)
    {
        double num1 = 20;
        double num2 = 4;

        Console.WriteLine($"{num1} + {num2} = {CalcProgram.funcCalc(num1, num2, '+')}");

        Console.WriteLine($"{num1} - {num2} = {CalcProgram.funcCalc(num1, num2, '-')}");

        Console.WriteLine($"{num1} * {num2} = {CalcProgram.funcCalc(num1, num2, '*')}");

        Console.WriteLine($"{num1} / {num2} = {CalcProgram.funcCalc(num1, num2, '/')}");

        Console.WriteLine($"{num1} / 0 = {CalcProgram.funcCalc(num1, 0, '/')}");
    }
}
