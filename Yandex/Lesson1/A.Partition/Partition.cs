namespace Yandex.Lesson1.A.Partition;

// A. Partition https://contest.yandex.ru/contest/53029/problems/A/
public class Partition : IProblem
{
    public void Run()
    {
        var n = ConsoleHelper.ReadInts()[0];
        var nums = ConsoleHelper.ReadInts();
        var x = ConsoleHelper.ReadInts()[0];

        var eIndex = ExecutePartition(nums, x);
        
        Console.WriteLine(eIndex);
        Console.WriteLine(n - eIndex);
    }

    public int ExecutePartition(int[] nums, int pivotIndex)
    {
        int eIndex = 0;
        int gIndex = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            var current = nums[i];
            if (current < nums[pivotIndex])
            {
                nums[i] = nums[gIndex];
                nums[gIndex] = nums[eIndex];
                nums[eIndex] = current;
                eIndex++;
                gIndex++;
            }

            if (current == nums[pivotIndex])
            {
                nums[i] = nums[gIndex];
                nums[gIndex] = current;
                gIndex++;
            }

        }

        return eIndex;
    }
}