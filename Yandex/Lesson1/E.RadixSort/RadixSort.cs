using System.Text;

namespace Yandex.Lesson1.E.RadixSort;

public class RadixSort : IProblem
{
    private string[] GetNums()
    {
        var n = int.Parse(Console.ReadLine() ?? string.Empty);
        var nums = new string[n];
        for (int i = 0; i < n; i++)
        {
            nums[i] = Console.ReadLine();
        }

        return nums;
    }

    private int GetNumberOfPhases(string[] nums)
    {
        return nums.Length > 0 ? nums[0].Length : 0;
    }

    private Dictionary<char, List<string>> CreateBuckets()
    {
        var buckets = new Dictionary<char, List<string>>();
        for (char i = '0'; i <= '9'; i++)
        {
            buckets.Add(i, new List<string>());
        }

        return buckets;
    }

    private Dictionary<char, int> CreatePositionsDict(Dictionary<char, List<string>> buckets)
    {
        var pos = new Dictionary<char, int>();
        var countPrev = 0;
        var posPrev = 0;
        foreach (var bucket in buckets)
        {
            pos.Add(bucket.Key, posPrev);
            countPrev = bucket.Value.Count;
            posPrev += countPrev;
        }
        return pos;
    }

    private void FillBuckets(Dictionary<char, List<string>> buckets, string[] nums, int i, int numberOfPhases)
    {
        foreach (string n in nums)
        {
            var d = n.ElementAt(numberOfPhases - i);
            buckets[d].Add(n);
        }
    }
    public void Run()
    {
        var nums = GetNums();
        var result = new string[nums.Length];
        Console.WriteLine("Initial array:");
        Console.WriteLine(FormatAndJoin(nums));
        Console.WriteLine("**********");

        var buckets = CreateBuckets();
        
        var numberOfPhases = GetNumberOfPhases(nums);
        for (int i = 1; i <= numberOfPhases; i++)
        {
            Console.WriteLine($"Phase {i}");

            FillBuckets(buckets, nums, i, numberOfPhases);
            
            var pos = CreatePositionsDict(buckets);
            
            const string empty = "empty";
            foreach (var bucket in buckets)
            {
                Console.WriteLine($"Bucket {bucket.Key}: {(bucket.Value.Count > 0 ? FormatAndJoin(bucket.Value) : empty)}");
                foreach (string bucketValue in bucket.Value)
                {
                    int index = pos[bucket.Key];
                    result[index] = bucketValue;
                    pos[bucket.Key]++;
                }
                bucket.Value.Clear();
            }

            nums = result;
            Console.WriteLine("**********");
        }
        
        Console.WriteLine("Sorted array:");
        Console.WriteLine(FormatAndJoin(result));
    }

    private string FormatAndJoin(IEnumerable<string> nums)
    {
        return string.Concat(nums.Select(d => $"{d:00}" + ", ")).TrimEnd(' ', ',');
    }
    public int GetDigit(int n, int place)
    {
        return (n / (int)Math.Pow(10, place -1) % 10);
    }
}