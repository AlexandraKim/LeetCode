namespace LeetCode.Easy.SingleNumber;

public class SingleNumber
{
  public int Run(int[] nums) {
    int answer = 0;
    for(int i = 0; i < nums.Length; i++){
      answer ^= nums[i];
    }
    
    return answer;
  }
}