using System;
using System.Collections;

namespace Permutation
{
  class CheckPermutation
  {
    public static void Main(string[] args)
    {
      if (args.Length == 2)
      {
        string w1 = args[0];
        string w2 = args[1];
        if (Check(w1, w2))
        {
          Console.WriteLine("{0} and {1} are Permutations", w1, w2);
        }
        else
          Console.WriteLine("{0} and {1} are not Permutations", w1, w2);
      }
      else
        Console.WriteLine("Please provide 2 strings");

    }

    static bool Check(string str1, string str2)
    {
      if (str1.Length != str2.Length)
        return false;

      char[] str1Array = str1.ToCharArray();
      char[] str2Array = str2.ToCharArray();

      Array.Sort(str1Array);
      Array.Sort(str2Array);

      str1 = new string(str1Array);
      str2 = new string(str2Array);

      if (str1 == str2)
        return true;

      return false;
    }
  }
}
