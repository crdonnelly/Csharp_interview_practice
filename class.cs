import System;

public class Customer
{
  public static void Main()
  {
    Customer object1 = new Customer(); //Create a new instance of Customer with "new" keyword
    Customer object2; //Create object reference without an object (not reccomended)
    Customer object3 = new Customer(); //Same as #1
    Customer object4 = object3; // Both object3 and object 4 are references to the same object
  }
  //Fields, Properties, Methods and events go here
}
 public class Manager : Employee
 {
   // Employee fields, properties, methods and events are inherited
   // New Manager fields, properties, methods and events go here
 }
