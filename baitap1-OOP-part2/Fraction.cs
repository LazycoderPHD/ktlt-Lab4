using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap_OOP_part2
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

        public int GetNumerator() => numerator;
        public int GetDenominator() => denominator;

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

        public static Fraction operator -(Fraction a) => new Fraction(-a.numerator, a.denominator);

        public static Fraction operator +(Fraction a, Fraction b) =>
            new Fraction(a.numerator * b.denominator + b.numerator * a.denominator, a.denominator * b.denominator);

        public static Fraction operator -(Fraction a, Fraction b) =>
            new Fraction(a.numerator * b.denominator - b.numerator * a.denominator, a.denominator * b.denominator);

        public static Fraction operator *(Fraction a, Fraction b) =>
            new Fraction(a.numerator * b.numerator, a.denominator * b.denominator);

        public static Fraction operator /(Fraction a, Fraction b) =>
            new Fraction(a.numerator * b.denominator, a.denominator * b.numerator);

        public static bool operator ==(Fraction a, Fraction b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null)) return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;
            return a.numerator * b.denominator == b.numerator * a.denominator;
        }

        public static bool operator !=(Fraction a, Fraction b) => !(a == b);

        public static bool operator >(Fraction a, Fraction b) =>
            a.numerator * b.denominator > b.numerator * a.denominator;

        public static bool operator <(Fraction a, Fraction b) =>
            a.numerator * b.denominator < b.numerator * a.denominator;

        public static bool operator >=(Fraction a, Fraction b) =>
            a.numerator * b.denominator >= b.numerator * a.denominator;

        public static bool operator <=(Fraction a, Fraction b) =>
            a.numerator * b.denominator <= b.numerator * a.denominator;

        public override bool Equals(object? obj) => obj is Fraction f && this == f;
        public override int GetHashCode() => HashCode.Combine(numerator, denominator);
    }
}
