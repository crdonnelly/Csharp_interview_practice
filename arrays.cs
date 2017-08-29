//arrays.cs
using System;
class PracticeArrays
{
  public static void Main()
  {
    //Single-dimensional array
    int[] numbers = new int[5];

    //Multi-dimensional array
    string[,] names = new string[5,4];

    //Array-of-arrays
    byte[][] scores = new byte[5][];

    //Create jagged array
    for (int i = 0; i < scores.Length; i++)
    {
      Console.WriteLine("Length of row {0} is {1}", i, scores[i].Length);
    }
  }
}
