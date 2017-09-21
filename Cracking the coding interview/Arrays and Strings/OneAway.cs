using System;

namespace OneAwayApp
{
  class OneAway
  {
    public static void Main(string[] args)
    {
      string input1 = "Flask";
      string input2 = "ask";
      if (IsOneAway(input1, input2))
      {
        Console.WriteLine("True");
      }
      else
        Console.WriteLine("False");
    }

    static bool IsOneAway(string word1, string word2)
    {
      char[] word1Arr;
      char[] word2Arr;
      char[] longWord;
      char[] shortWord;

      if (word1.Equals(word2))
        return true;

      else if (word1.Length == word2.Length)
      {
        word1Arr = word1.ToCharArray();
        word2Arr = word2.ToCharArray();
        int diff = 0;
        for (int i = 0; i < word1.Length; i++)
        {
          if (word1Arr[i] != word2Arr[i])
            diff += 1;
          if (diff > 1)
            return false;
        }
        return true;
      }
      else
      {
        if (word1.Length > word2.Length)
        {
          longWord = word1.ToCharArray();
          shortWord = word2.ToCharArray();
        }
        else
        {
          longWord = word2.ToCharArray();
          shortWord = word1.ToCharArray();
        }
        int i = 0;
        while (i != 2)
        {
          int count = 0;
          for (int j = 0; j < shortWord.Length; j++)
          {
            if (longWord[i+j] == shortWord[j])
              count += 1;
            if (count == shortWord.Length)
              return true;
          }
          i++;
        }
        return false;
      }
    }
  }
}
