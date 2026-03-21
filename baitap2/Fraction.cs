using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap2
{
    public class Fraction
    {
        protected int numerator;
        protected int denominator;

        public Fraction() { numerator = 0; denominator = 1; }
        public Fraction(int n) { numerator = n; denominator = 1; }
        public Fraction(int n, int d)
        {
            numerator = n;
            denominator = d != 0 ? d : 1;
            Simplify();
        }

        private int GCD(int a, int b)
        {
            a = Math.Abs(a); b = Math.Abs(b);
            while (a != b)
            {
                if (a > b) a -= b;
                else b -= a;
            }
            return a;
        }

        public void Simplify()
        {
            if (numerator == 0) return;
            int common = GCD(numerator, denominator);
            numerator /= common;
            denominator /= common;
        }

        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }

        // Các phương thức tính toán khác (Add, Subtract...) có thể bổ sung tại đây
    }
}
