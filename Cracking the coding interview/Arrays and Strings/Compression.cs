using System;
using System.Text;

namespace Compression
{
  class StringCompression
  {
    public static void Main(string[] args)
    {
      string input = "aabcccccaaa";
      string output = Compress(input);
      Console.WriteLine(output);
    }

    static string Compress(string str)
    {
      char[] strArr = str.ToCharArray();
      int pointer = 0;
      int count = 0;
      char character = ' ';
      StringBuilder compressedArray = new StringBuilder();
      while (pointer < strArr.Length)
      {
        if (character == ' ')
        {
          character = strArr[pointer];
          count += 1;
        }
        else if (character == strArr[pointer])
        {
          count += 1;
        }
        else if (character != strArr[pointer])
        {
          compressedArray.Append(character);
          compressedArray.Append(count);
          character = strArr[pointer];
          count = 1;
        }
        pointer += 1;
      }
      compressedArray.Append(character);
      compressedArray.Append(count);
      return compressedArray.ToString();
    }
  }
}
