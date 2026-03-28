using System;

namespace baitap_OOP_part2
{
    public class MixedFraction : Fraction
    {
        public MixedFraction(int wholePart, int numerator, int denominator)
        {
            this.denominator = denominator != 0 ? denominator : 1;
            this.numerator = (wholePart * this.denominator) + numerator;
            Simplify();
        }

        public MixedFraction(Fraction f)
        {
            this.numerator = f.GetNumerator();
            this.denominator = f.GetDenominator();
            Simplify();
        }

        public override string ToString()
        {
            int whole = numerator / denominator;
            int rem = Math.Abs(numerator % denominator);
            if (rem == 0) return $"{whole}";
            return $"{whole} [{rem}/{denominator}]";
        }
    }
}