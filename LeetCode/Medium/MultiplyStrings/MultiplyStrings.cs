namespace LeetCode.Medium.MultiplyStrings;

// 43. Multiply Strings https://leetcode.com/problems/multiply-strings
public class MultiplyStrings
{
    public string Multiply(string a, string b)
    {
        if (a == "0" || b == "0")
        {
            return "0";
        }
        var multiplicationResult = MultiplyInternal(a, b);

        var sumResult = Sum(multiplicationResult);

        string result = string.Join("", sumResult);
        if (sumResult[0] == 0) {
            result = result.Substring(1);
        }
        return string.Join("", result);
    }

    private int[] InitArrayOfZeros(int length)
    {
        var result = new int[length];

        for (var i = 0; i < length; i++) result[i] = 0;
        
        return result;
    }

    private int[] MultiplyInternal(string a, string b)
    {
        var aLen = a.Length;
        var bLen = b.Length;
        var result = InitArrayOfZeros(aLen + bLen);

        var carry = 0;
        for (var i = aLen - 1; i >= 0; i--)
        {
            var aCurDigit = a[i] - '0';
            for (var j = bLen - 1; j >= 0; j--)
            {
                var bCurDigit = b[j] - '0';
                var multiplication = aCurDigit * bCurDigit;
                result[i + j + 1] += multiplication % 10 + carry;
                carry = multiplication / 10;
            }

            result[i] += carry;
            carry = 0;
        }

        return result;
    }

    private int[] Sum(int[] numbers)
    {
        int carry = 0;
        for (var i = numbers.Length - 1; i >= 0; i--)
        {
            var currentValue = numbers[i] + carry;
            numbers[i] = currentValue % 10 ;
            carry = currentValue / 10;
        }

        return numbers;
    }
}