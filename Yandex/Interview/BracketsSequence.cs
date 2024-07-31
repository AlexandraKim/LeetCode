using System.Text;

namespace Yandex.Interview;

// https://neerc.ifmo.ru/wiki/index.php?title=%D0%9F%D1%80%D0%B0%D0%B2%D0%B8%D0%BB%D1%8C%D0%BD%D1%8B%D0%B5_%D1%81%D0%BA%D0%BE%D0%B1%D0%BE%D1%87%D0%BD%D1%8B%D0%B5_%D0%BF%D0%BE%D1%81%D0%BB%D0%B5%D0%B4%D0%BE%D0%B2%D0%B0%D1%82%D0%B5%D0%BB%D1%8C%D0%BD%D0%BE%D1%81%D1%82%D0%B8
public class BracketsSequence : IProblem
{
  public void Run()
  {
    int n = int.Parse(Console.ReadLine());

    Order(n);
  }

  private string Generate(int n, int counterOpen, int counterClose, string s)
  {
    if (counterOpen + counterClose > 2*n)
    {
      return "";
    }

    if (counterOpen < n)
    {
      return Generate(n, counterOpen + 1, counterClose, s += "(");
    }
    if (counterOpen > counterClose)
    {
      return Generate(n, counterOpen, counterClose + 1, s += ")");
    }

    return s;
  }

  private string Next(string s)
  {
    int counterOpen = 0;
    int counterClose = 0;

    for (int i = s.Length-1; i >= 0; i--)
    {
      if (s[i] == '(')
      {
        counterOpen++;
        if (counterClose > counterOpen)
        {
          break;
        }
      }
      else
      {
        counterClose++;
      }
    }

    var modifiedString = s.Remove(s.Length - counterOpen - counterClose);
    if (modifiedString == "")
    {
      return ""; 
    }
    modifiedString += ')';
    for (int i = 0; i < counterOpen; i++)
    {
      modifiedString += '(';
    }
    for (int i = 0; i < counterClose - 1; i++)
    {
      modifiedString += ')';
    }

    return modifiedString;
  }

  private void Order(int n)
  {
    string s = Generate(n, 0, 0, "");
    StringBuilder sb = new StringBuilder(s + "\n");
    while (Next(s) != "")
    {
      s = Next(s);
      sb.Append(s + "\n");
    }
    Console.WriteLine(sb.ToString());
  }
}