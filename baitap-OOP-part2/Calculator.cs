using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap_OOP_part2
{
    public class Calculator
    {
        public Calculator() { }
        public static int Add(int a, int b) => a + b;
        public static double Add(double a, double b) => a + b;

        public int Subtract(int a, int b) => a - b;
        public double Subtract(double a, double b) => a - b;

        public int Multiply(int a, int b) => a * b;
        public double Multiply(double a, double b) => a * b;

        public double Divide(int a, int b) => (double)a / b;
        public double Divide(double a, double b) => a / b;

        public int Min(int a, int b) => Math.Min(a, b);
        public int Min(int a, int b, int c) => Math.Min(a, Math.Min(b, c));
        public double Min(double a, double b, double c) => Math.Min(a, Math.Min(b, c));

        public int Max(int a, int b) => Math.Max(a, b);
        public int Max(int a, int b, int c) => Math.Max(a, Math.Max(b, c));
        public double Max(double a, double b, double c) => Math.Max(a, Math.Max(b, c));
    }

}
