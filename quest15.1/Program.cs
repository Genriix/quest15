using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest15._1
{
    static class Calculator
    {
        public static double Add(double a, double b) { return a + b; }
        public static double Subtract(double a, double b) { return a - b; }
        public static double Multiply(double a, double b) { return a * b; }
        public static double Divide(double a, double b)
        {
            if (b != 0) { return a / b; }
            else { throw new DivideByZeroException("Деление на ноль невозможно"); }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите первое число:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Результат сложения: {Calculator.Add(num1, num2)}");
            Console.WriteLine($"Результат вычитания: {Calculator.Subtract(num1, num2)}");
            Console.WriteLine($"Результат умножения: {Calculator.Multiply(num1, num2)}");

            try { Console.WriteLine($"Результат деления: {Calculator.Divide(num1, num2)}"); }
            catch (DivideByZeroException ex) { Console.WriteLine(ex.Message); }

            Console.ReadKey();
        }
    }
}
