using baitap1_OOP_part2;

RunCalculatorDemo();
RunFractionOperatorDemo();

void RunCalculatorDemo()
{
    Console.WriteLine("Test Calculator");
    Console.WriteLine($"Add(5, 10) = {Calculator.Add(5, 10)}");
    Console.WriteLine($"Max(3.5, 7.2, 1.1) = {Calculator.Max(3.5, 7.2, 1.1)}");
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