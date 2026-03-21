using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap1_OOP_part2
{
    public class Calculator
    {
        public static int Add(int a, int b) => a + b;
        public static double Add(double a, double b) => a + b;

        public static int Subtract(int a, int b) => a - b;
        public static double Subtract(double a, double b) => a - b;

        public static int Multiply(int a, int b) => a * b;
        public static double Multiply(double a, double b) => a * b;

        public static double Divide(int a, int b) => (double)a / b;
        public static double Divide(double a, double b) => a / b;

        public static int Min(int a, int b) => Math.Min(a, b);
        public static int Min(int a, int b, int c) => Math.Min(a, Math.Min(b, c));
        public static double Min(double a, double b, double c) => Math.Min(a, Math.Min(b, c));

        public static int Max(int a, int b) => Math.Max(a, b);
        public static int Max(int a, int b, int c) => Math.Max(a, Math.Max(b, c));
        public static double Max(double a, double b, double c) => Math.Max(a, Math.Max(b, c));
    }

}
