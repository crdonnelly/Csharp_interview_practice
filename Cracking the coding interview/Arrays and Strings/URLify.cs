using System;

namespace URLifyApp
{
  class URLify
  {
    public static void Main(string[] args)
    {
      string str1 = new string(MakeURL("Mr John Smith    ", 13));
      Console.WriteLine("Input: 'Mr John Smith    ', 13");
      Console.WriteLine("Output: '{0}'", str1);

      string str2 = new string(MakeURL("Mr Cameron Donnelly Bsc      ", 23));
      Console.WriteLine("Input: 'Mr Cameron Donnelly Bsc      ', 23");
      Console.WriteLine("Output: '{0}'", str2);
      /**
      string str = MakeURL("Mr John Smith    ");
      **/
    }

    static char[] MakeURL(string str, int trueLength)
    {
      /**
      My second attempt
      Time complexity O(n)
      **/

      // Get the number of spaces (Not needed)
      int spaces = 0;
      char[] strArray = str.ToCharArray();
      for (int i = 0; i < trueLength; i++)
      {
        if (strArray[i].Equals(' '))
          spaces += 1;
      }

      // Work backward through the string
      int pointer = strArray.Length - 1;

      for (int i = trueLength - 1; i >= 0; i-- )
      {
        if (strArray[i].Equals(' '))
        {
          strArray[pointer] = '0';
          strArray[pointer - 1] = '2';
          strArray[pointer - 2] = '%';
          pointer -= 3;
        }
        else
        {
          strArray[pointer] = strArray[i];
          pointer -= 1;
        }

      }
      return strArray;
    }

/** My first attempt
Time complexity O(n) where n is the urlArray length
Space complexity O(1)

    static string MakeURL(string str)
    {
      char[] strArray = str.ToCharArray();
      char[] urlArray = new char[strArray.Length];

      int pointer = 0;
      int temppoint = 0;

      while (temppoint < urlArray.Length)
      {
        if (strArray[pointer] == ' ')
        {
          urlArray[temppoint] = '%';
          urlArray[temppoint + 1] = '2';
          urlArray[temppoint + 2] = '0';
          temppoint += 3;
        }
        else
        {
          urlArray[temppoint] = strArray[pointer];
          temppoint += 1;
        }
        pointer += 1;
      }

      return new string(urlArray);
    }
    **/
  }
}
