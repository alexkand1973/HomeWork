using System;
using System.Globalization;


namespace задача2
{
    internal class Program
    {
        public static string NumberDecimalSeparator { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите три числа, десятичные знаки отделяйте при помощи - .");

            string a;

            string d;

            string e;

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo();

            {
                NumberDecimalSeparator = ".";
            }

            a = Console.ReadLine();

            d = Console.ReadLine();

            e = Console.ReadLine();

            double v = Convert.ToDouble(a, numberFormatInfo);

            double s = Convert.ToDouble(d, numberFormatInfo);

            double x = Convert.ToDouble(e, numberFormatInfo);

            double Result = (double) v + s + x;

            double Result1 = (double) v * s * x;

            Console.WriteLine("Сумма чисел = " + Result);

            Console.WriteLine("Произведение чисел = " + Result1);
        }
    }
}
