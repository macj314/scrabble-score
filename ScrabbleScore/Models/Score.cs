using System.Linq;
using System;
namespace ScrabbleScore.Models
{
  public class Score
  {
    // input.ToLower().Count(i => i == 'x') == input.ToLower().Count(i => i == 'o');
    public static int GetScoreLinq(string input)
    {
      int result = 0;
      input = input.Trim('.', '?', '!', ' ', ';', ':', ',');
      input = input.ToLower();
      result += input.Count(c => c == 'q' || c == 'z') * 10;
      result += input.Count(c => c == 'j' || c == 'x') * 8;
      result += input.Count(c => c == 'k') * 5;
      result += input.Count(c => c == 'f' || c == 'h' || c == 'v' || c == 'w' || c == 'y') * 4;
      result += input.Count(c => c == 'b' || c == 'c' || c == 'm' || c == 'p') * 3;
      result += input.Count(c => c == 'd' || c == 'g') * 2;
      result += input.Count(c => c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'l' || c == 'n' || c == 'n' || c == 'r' || c == 's' || c == 't');
      return result;
    }
        public static int GetScoreIf(string input)
    {
      int result = 0;
      input = input.Trim('.', '?', '!', ' ', ';', ':', ',');
      input = input.ToLower();
      foreach(char c in input)
      {
        if (c == 'q' || c == 'z')
        {
          result += 10;
        } else if ( c == 'j' || c == 'x')
        {
          result += 8;
        } else if (c == 'k')
        {
          result += 5;
        } else if (c == 'f' || c == 'h' || c == 'v' || c == 'w' || c == 'y')
        {
          result += 4;
        } else if (c == 'b' || c == 'c' || c == 'm' || c == 'p')
        {
          result += 3;          
        } else if (c == 'd' || c == 'g')
        {
          result += 2;
        } else
        {
          result += 1;
        }
      }
      return result;
    }
  }
}
