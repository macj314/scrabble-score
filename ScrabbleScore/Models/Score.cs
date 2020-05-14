using System.Linq;
using System;
namespace ScrabbleScore.Models
{
  public class Score
  {
    // input.ToLower().Count(i => i == 'x') == input.ToLower().Count(i => i == 'o');
    public static int GetScore(string input)
    {
      int result = 0;
      char[] four = {'f', 'h', 'v', 'w', 'y'};
      input.ToLower();
      result += input.Count(c => c == 'q' || c == 'z') * 10;
      result += input.Count(c => c == 'j' || c == 'x') * 8;
      result += input.Count(c => c == 'k') * 5;
      result += input.Count(c => c == four[c]) * 4;
      return result;
    }
  }
}
