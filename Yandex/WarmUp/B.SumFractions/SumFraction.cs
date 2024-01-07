using Yandex.WarmUp.A.NotMinimum;

namespace Yandex.WarmUp.B.SumFractions;

public class SumFraction : IProblem
{
    public void Run()
    {
        var nums = ConsoleHelper.ReadInts();
        int a = nums[0];
        int b = nums[1];
        int c = nums[2];
        int d = nums[3];

        int commonDenominator = b != d ? Lcm(b, d) : b;

        int aMultiplier = commonDenominator / b;
        int cMultiplier = commonDenominator / d;

        int nominator = aMultiplier * a + cMultiplier * c;

        int divisor = Gcd(nominator, commonDenominator);

        nominator /= divisor;
        commonDenominator /= divisor;
        Console.WriteLine(nominator + " " + commonDenominator);
    }
    
    int Lcm(int a, int b) 
    { 
        return (a * b) / Gcd(a, b); 
    } 
    
    int Gcd(int a, int b)
    {
        if (a == 0)
            return b;
        return Gcd(b % a, a);
    }
}