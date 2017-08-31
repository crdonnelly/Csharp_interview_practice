using System;
namespace StringApp
{
  class Program
  {
    static void Main(string[] args)
    {
      string fname, lname;
      fname = "Cameron";
      lname = "Donnelly";

      string fullName = fname + lname;
      Console.WriteLine("Full Name: {0}", fullName);

      char[] letters = {'H','i',' ','t','h','e','r','e'};
      string greetings = new string(letters);
      Console.WriteLine("Greetings: {0}", greetings);

      string[] sarray = {"Hello", "From", "Cameron"};
      string message = String.Join(" ", sarray);
      Console.WriteLine("Message: {0}", message);

      DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
      string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
      Console.WriteLine("Message: {0}", chat);
    }
  }
}
