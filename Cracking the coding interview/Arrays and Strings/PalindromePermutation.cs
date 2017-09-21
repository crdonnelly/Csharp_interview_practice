using System;

namespace PalindromeApp
{
  class IsPalindromePermutation
  {
    public static void Main(string[] args)
    {

    }

    bool isPermutationOfPalindrome(string phrase)
    {
      int[] table = buildCharacterFrequencyTable(phrase);
      return checkMaxOneOdd(table);
    }

    /* Check that no more than one character has am odd count */
    bool checkMaxOneOdd(int[] table)
    {
      bool foundOdd = false;
      foreach (int count in table)
      {
        if (count % 2 == 1)
        {
          if (foundOdd)
          {
            return false;
          }
          foundOdd = true;
        }
      }
      return true;
    }

    /* Map each character to a number. a -> 0, b -> 1, c -> 2, etc.
    * this is case insensitive. Non-letter characters map to -1. */
    int getCharNumber(char c)
    {
      int a = char.GetNumericValue('a');
      int z = char.GetNumericValue('z');
      int val = char.GetNumericValue(c);
      if (a <= val && val <= z)
      {
        return val - a;
      }
      return -1;
    }

    /* Count how many times each character appears. */
  }
}
