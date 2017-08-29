//arrays.cs
using System;
using System.Collections;
class PracticeArrays
{
  public static void Main(string[] arg1)
  {
    if (arg1[0] == "example")
    {
      example();
    }
    else if (arg1[0] == "single")
    {
      single();
    }
  }

  public static void example()
  {
    //Single-dimensional array
    int[] numbers = new int[5];

    //Multi-dimensional array
    string[,] names = new string[5,4];

    //Array-of-arrays
    byte[][] scores = new byte[5][];

    //Create the jagged array
    for (int i = 0; i < scores.Length; i++)
    {
      scores[i] = new byte[i+3];
    }

    //Print the Length of each row
    for (int i = 0; i < scores.Length; i++)
    {
      Console.WriteLine("Length of row {0} is {1}", i, scores[i].Length);
    }
  }

  public static void single()
  {

  }
}
