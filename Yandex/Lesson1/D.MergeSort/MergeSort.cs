namespace Yandex.Lesson1.D.MergeSort;

public class MergeSort : IProblem
{
    public void Run()
    {
        var n = ConsoleHelper.ReadInts()[0];
        var nums = ConsoleHelper.ReadInts();

        var result = Sort(nums, 0, n);

        Console.WriteLine(string.Join(" ", result));
    }

    private int[] Sort(int[] nums, int lIndex, int rIndex)
    {
        int mIndex = (rIndex + lIndex) / 2;
        if ((rIndex - lIndex) == 1)
        {
            return new int[] {nums[lIndex]};
        }
        if (rIndex <= lIndex)
        {
            return new int[] {};
        }
        var left = Sort(nums, lIndex, mIndex);
        var right = Sort(nums, mIndex, rIndex);

        return ExecuteMerge(left, right);
    }
    
    private static int[] ExecuteMerge(int[] left, int[] right)
    {
        var rIndex = 0;
        var lIndex = 0;
        var result = new int[left.Length + right.Length];
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
    
    private static int[] ExecuteMergeByIndex(int[] nums, int startIndex, int endIndex, int middleIndex)
    {
        var lIndex = startIndex;
        var rIndex = middleIndex;
        var result = new int[endIndex+1];
        for (var i = startIndex; i <= endIndex; i++)
        {
            if (lIndex < middleIndex && rIndex <= endIndex)
            {
                if (nums[lIndex] < nums[rIndex])
                {
                    result[i] = nums[lIndex];
                    lIndex++;
                }
                else
                {
                    result[i] = nums[rIndex];
                    rIndex++;
                }
            }
            else if (lIndex >= middleIndex)
            {
                result[i] = nums[rIndex];
                rIndex++;
            }
            else if (rIndex >= endIndex)
            {
                result[i] = nums[lIndex];
                lIndex++;
            }
        }

        return result;
    }
}