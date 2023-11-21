namespace Yandex;

public class ConsoleHelper
{
    public static int[] ReadInts()
    {
        var str = Console.ReadLine();
        if (str == string.Empty)
        {
            return Array.Empty<int>();
        }

        var strArray = str.Split(" ");
        var array = new int[strArray.Length];
        for (var i = 0; i < strArray.Length; i++)
        {
            array[i] = int.Parse(strArray[i]);
        }

        return array;
    }
    
    public static int ReadInt()
    {
        var str = Console.ReadLine();
        return str == string.Empty ? default : int.Parse(str ?? string.Empty);
    }
}