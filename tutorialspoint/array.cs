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
      Console.WriteLine("\nLets do the same using a foreach statement\n");
      //Lets use a foreach instead
      foreach (int i in myArray)
      {
        Console.WriteLine("myArray[{0}] = {1}", i, myArray[i]);
      }
    }
  }
}
