namespace Yandex.Lesson1.C.Merge;

public class Merge : IProblem
{
    public void Run()
    {
        var leftLength = ConsoleHelper.ReadInts()[0];
        var left = ConsoleHelper.ReadInts();
        var rightLength = ConsoleHelper.ReadInts()[0];
        var right = ConsoleHelper.ReadInts();
        var result = new int[leftLength + rightLength];

        result = ExecuteMerge(left, right, result);

        Console.WriteLine(string.Join(" ", result));
    }

    private static int[] ExecuteMerge(int[] left, int[] right, int[] result)
    {
        var rIndex = 0;
        var lIndex = 0;
        for (var i = 0; i < result.Length; i++)
        {
            if (lIndex < left.Length && rIndex < right.Length)
            {
                if (left[lIndex] < right[rIndex])
                {
                    result[i] = left[lIndex];
                    lIndex++;
                }
                else
                {
                    result[i] = right[rIndex];
                    rIndex++;
                }
            }
            else if (lIndex >= left.Length)
            {
                result[i] = right[rIndex];
                rIndex++;
            }
            else if (rIndex >= right.Length)
            {
                result[i] = left[lIndex];
                lIndex++;
            }
        }

        return result;
    }
}