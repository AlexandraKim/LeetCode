namespace Yandex.Lesson1.B.QuickSort;

// B. Быстрая сортировка https://contest.yandex.ru/contest/53029/problems/B/
public class QuickSort : IProblem
{
    private readonly Random Rand = new Random();
    public void Run()
    {
        var n = ConsoleHelper.ReadInt();
        var nums = ConsoleHelper.ReadInts();

        Sort(nums, 0, n);
        
        Console.WriteLine(string.Join(" ", nums));
    }

    private void Sort(int[] nums, int lIndex, int rIndex)
    {
        if (lIndex >= rIndex)
        {
            return;
        }
        (int eIndex, int gIndex) = ExecutePartition(nums, lIndex, rIndex);
        Sort(nums, lIndex, eIndex);
        Sort(nums, gIndex, rIndex);
    }
    
    private (int eIndex, int gIndex) ExecutePartition(int[] nums, int lIndex, int rIndex)
    {
        int pivotIndex  = Rand.Next(lIndex, rIndex);
        int eIndex = lIndex;
        int gIndex = lIndex;

        int pivot = nums[pivotIndex];
        for (int i = lIndex; i < rIndex; i++)
        {
            if (gIndex == rIndex)
            {
                continue;
            }
            var current = nums[i];
            
            if (current < pivot)
            {
                nums[i] = nums[gIndex];
                nums[gIndex] = nums[eIndex];
                nums[eIndex] = current;
                eIndex++;
                gIndex++;
            }

            if (current == pivot)
            {
                nums[i] = nums[gIndex];
                nums[gIndex] = current;
                gIndex++;
            }

        }

        return (eIndex, gIndex);
    }
}