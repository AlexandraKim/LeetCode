using Yandex.Utility;

namespace Yandex.Interview;

public class AnagramChecker : IProblem
{
  public void Run()
  {
    Console.WriteLine(Check());
  }
  
  private static int Check(){
    string s1 = Console.ReadLine();
    string s2 = Console.ReadLine();
		
    if (s1 == s2) { return 1; }
    if (s1.Length != s2.Length) { return 0; }
    var alphabet = new int[26];
    for (int i = 0; i < s1.Length; i++) {
      alphabet[s1[i] - 'a']++;
    }
    for (int i = 0; i < s2.Length; i++) {
      alphabet[s2[i] - 'a']--;
    }

    for (int i = 0; i < 26; i++) {
      if(alphabet[i] > 0) {
        return 0;
      }
    }
    return 1;

  }

}