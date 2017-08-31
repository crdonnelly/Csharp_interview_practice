using System;

public class Person
{
  // Field(s)
  public string name;

  // Constructor that takes no arguments.
  public Person()
  {
    name = "unknown";
  }

  // Constructor that takes one argument.
  public Person(string nm)
  {
    name = nm;
  }

  // Method
  public void SetName(string newName)
  {
    name = newName;
  }
}
class TestPerson
{
  static void Main()
  {
    // Call constructor with no parameters
    Person person1 = new Person();
    Console.WriteLine(person1.name);

    person1.SetName("John Smith");
    Console.WriteLine(person1.name);

    // Call constructor with one parameter
    Person person2 = new Person("Sarah Jones");
    Console.WriteLine(person2.name);

    // Keep console open
    Console.WriteLine("Press any key to exit.");
    Console.ReadKey();
  }
}
