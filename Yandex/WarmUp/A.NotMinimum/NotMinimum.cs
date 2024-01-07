using System.Text;

namespace Yandex.WarmUp.A.NotMinimum;

public class NotMinimum : IProblem
{
    public void Run()
    {
        var firstLine = ConsoleHelper.ReadInts();
        int m = firstLine[1];
        
        int[] sequence = ConsoleHelper.ReadInts();

        for (int i = 0; i < m; i++)
        {
            int[] request = ConsoleHelper.ReadInts();
            int l = request[0];
            int r = request[1];
            int min = sequence[l];
            var found = false;
            for (int j = l; j <= r; j++)
            {
                if (sequence[j] < min)
                {
                    Console.WriteLine(min.ToString());
                    found = true;
                    min = sequence[j];
                    break;
                    
                }

                if (sequence[j] > min)
                {
                    Console.WriteLine(sequence[j].ToString());
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("NOT FOUND");
            }
        }
    }
}