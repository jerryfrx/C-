//1,9 -> 1,2,3,4,6,7,8,9 -> Result 8
//4,17 -> 4,6,7,8,9,10,11,12,13,14,16,17 -> Result 12

public class Kata {
  public static int DontGiveMeFive(int start, int end) {
    int count = 0;
    for(int i = start; i <= end; i++) {
      string temp = i.ToString();
      if(!temp.Contains("5")) count++;
    }
    
    return count;
  }
}