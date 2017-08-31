using System;
namespace arrayTutorial
{
  class MyArray
  {
    public static void Main(string[] args)
    {
      int[] myArray = new int[5];

      for (int i=0; i < 5; i++)
      {
        myArray[i] = i;
      }

      for (int i=0; i<5;i++)
      {
        Console.WriteLine("myArray[{0}] = {1}", i, myArray[i]);
      }
    }
  }
}
