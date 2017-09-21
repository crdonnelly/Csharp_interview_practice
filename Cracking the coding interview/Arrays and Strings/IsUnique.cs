using System;

namespace IsUniqueApp
{
  class IsUnique
  {
      public static void Main(string[] args)
      {
        Console.WriteLine("Is the word ABBA unique?");
        if (IsUniqueChars("ABBA"))
          Console.WriteLine("Yes");
        else
          Console.WriteLine("No\n");

        Console.WriteLine("Is the word Cameron unique?");
        if (IsUniqueChars("Cameron"))
          Console.WriteLine("Yes");
        else
          Console.WriteLine("No\n");
      }

      static bool IsUniqueChars(string str)
      {
        if (str.Length > 128)
          return false;

        bool[] char_set = new bool[128];
        for (int i = 0; i < str.Length; i++)
        {
          int val = str[i];
          if (char_set[val])
            return false;

          char_set[val] = true;
        }
        return true;
      }
  }
}
