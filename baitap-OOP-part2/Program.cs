using baitap_OOP_part2;

RunCalculatorDemo();
RunFractionOperatorDemo();

void RunCalculatorDemo()
{
    Console.WriteLine("Test Calculator");
    Console.WriteLine($"Add(5, 10) = {Calculator.Add(5, 10)}");
    Console.WriteLine($"Add(4.5, 5.5) = {Calculator.Add(4.5,5.5)}");
    Calculator calc = new Calculator();
    Console.WriteLine();
    Console.WriteLine("── Subtract ─────────────");
    Console.WriteLine("Subtract(10, 4) = " + calc.Subtract(10, 4));
    Console.WriteLine("Subtract(5.5, 1.1) = " + calc.Subtract(5.5, 1.1));
    Console.WriteLine("── Multiply ─────────────");
    Console.WriteLine("Multiply(3, 4) = " + calc.Multiply(3, 4));      // 12
    Console.WriteLine("Multiply(2.5, 2.0) = " + calc.Multiply(2.5, 2.0)); // 5.0
    Console.WriteLine("── Divide ───────────────");
    Console.WriteLine("Divide(7, 2) = " + calc.Divide(7, 2));        // 3.5
    Console.WriteLine("Divide(7.0, 2.0) = " + calc.Divide(7.0, 2.0));   // 3.5
    Console.WriteLine("Divide(5, 0) = " + calc.Divide(5, 0));        // Error message
    Console.WriteLine("── Min ──────────────────");
    Console.WriteLine("Min(3, 7) = " + calc.Min(3, 7));           // 3
    Console.WriteLine("Min(3, 7, 1) = " + calc.Min(3, 7, 1));        // 1
    Console.WriteLine("Min(3.5, 7.2, 1.1) = " + calc.Min(3.5, 7.2, 1.1)); // 1.1
    Console.WriteLine("── Max ──────────────────");
    Console.WriteLine("Max(3, 7) = " + calc.Max(3, 7));           // 7
    Console.WriteLine("Max(3, 7, 1) = " + calc.Max(3, 7, 1));        // 7
    Console.WriteLine("Max(3.5, 7.2, 1.1) = " + calc.Max(3.5, 7.2, 1.1)); // 7.2
    Console.WriteLine();
}


void RunFractionOperatorDemo()
{
    Console.WriteLine("Test Fraction, MixedFraction");
    Fraction f1 = new Fraction(1, 2);
    Fraction f2 = new Fraction(1, 3);
    MixedFraction mf1 = new MixedFraction(1, 1, 2);

    Console.WriteLine($"f1 = {f1}");
    Console.WriteLine($"f2 = {f2}");
    Console.WriteLine($"mf1 = {mf1}");

    Console.WriteLine($"-f1 = {-f1}");
    Console.WriteLine($"f1 + f2 = {f1 + f2}");
    Console.WriteLine($"f1 * f2 = {f1 * f2}");

    // Đa hình: Hỗn số vẫn dùng được các toán tử vì kế thừa từ Fraction
    Console.WriteLine($"mf1 + f1 = {mf1 + f1}");
    Console.WriteLine($"f1 > f2: {f1 > f2}");
    Console.WriteLine($"f1 == f2: {f1 == f2}");
}