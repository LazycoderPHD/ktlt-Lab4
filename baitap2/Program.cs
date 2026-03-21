using baitap2;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

RunFractionDemo();
void RunFractionDemo()
{
    Fraction f = new Fraction(7, 3);
    Console.WriteLine($"Phân số ban đầu: {f}");
}

Console.WriteLine("\n");


RunMixedFractionDemo();
//void RunMixedFractionDemo()
//{
//    MixedFraction mf1 = new MixedFraction(2, 1, 3);
//    Console.WriteLine($"Hỗn số từ (2, 1, 3): {mf1}");

//    MixedFraction mf2 = new MixedFraction(f);
//    Console.WriteLine($"Hỗn số chuyển từ phân số {f}: {mf2}");
//}

void RunMixedFractionDemo()
{
    Fraction f = new Fraction(7, 3);

    MixedFraction mf1 = new MixedFraction(2, 1, 3);
    Console.WriteLine($"Hỗn số từ (2, 1, 3): {mf1}");

    MixedFraction mf2 = new MixedFraction(f);
    Console.WriteLine($"Hỗn số chuyển từ phân số {f}: {mf2}");
}