namespace Yandex.Interview;

public class ProblemA : IProblem
{
  public void Run()
  {
    MyRun();

  }

  private void MyRun()
  {
    string j = Console.ReadLine();
    string s = Console.ReadLine();
    if(s.Length == 0 || j.Length == 0){
      Console.WriteLine(0);
    }

    int count = 0;
    for(int i = 0; i < s.Length; i++) {
      char c = s[i];
      if(j.Contains(c)){
        count++;
      }
    }
    Console.WriteLine(count);
  }

  private void TheirRun()
  {
    string j = Console.ReadLine();
    string s = Console.ReadLine();
 
    int result = 0;
    foreach (char ch in s) {
      if (j.IndexOf(ch) >= 0) {
        ++result;
      }
    }
 
    Console.WriteLine(result);
  }
}