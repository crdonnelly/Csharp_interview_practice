using System;
using System.Collections.Generic;

namespace basicLinkedList
{
  class Node
  {
    Node next = null;
    public Node Next
    {
      get {return next;}
      set {next = value;}
    }
    int data;
    public int Data
    {
      get {return data;}
      set {data = value;}
    }

    public Node(int d)
    {
      data = d;
    }

    void AppendToTail(int d)
    {
      Node end = new Node(d);
      Node n = this;
      while (n.next != null)
      {
        n = n.next;
      }
      n.next = end;
    }

    Node deleteNode(Node head, int d)
    {
      Node n = head;

      if (n.data == d)
      {
        return head.next;
      }

      while (n.next != null)
      {
        if (n.next.data == d)
        {
          n.next = n.next.next;
          return head;
        }
        n = n.next;
      }
      return head;
    }

    static void PrintNodes(Node n)
    {
      int index = 0;
      Console.WriteLine("Node {0}: {1}", index, n.data);
      while (n.next != null)
      {
        index++;
        n = n.next;
        Console.WriteLine("Node {0}: {1}", index, n.data);
      }
    }
    public static void Main(string[] args)
    {
      Node myNode = new Node(1);
      myNode.AppendToTail(2);
      myNode.AppendToTail(3);
      myNode.AppendToTail(2);
      myNode.AppendToTail(7);
      myNode.AppendToTail(3);
      PrintNodes(myNode);
      Console.WriteLine("\n\n");
      //Questions.RemoveDupsNoBuffer(myNode);
      //PrintNodes(myNode);
      //Console.WriteLine("\n\n");
      int k = 2;
      Console.WriteLine("The second to last index is: " + Questions.KthToLast(myNode, k));
    }
  }

  class Questions
  {
    public static void RemoveDups(Node n)
    {
      HashSet<int> multiples = new HashSet<int>();
      Node previous = null;
      while (n != null)
      {
        if (multiples.Contains(n.Data))
        {
          previous.Next = n.Next;
        }
        else
        {
          multiples.Add(n.Data);
          previous = n;
        }
        n = n.Next;
      }
    }

    public static void RemoveDupsNoBuffer(Node n)
    {
      Node current = n;
      while (current != null)
      {
        Node runner = current;
        while (runner.Next != null)
        {
          if (runner.Next.Data == current.Data)
          {
            runner.Next = runner.Next.Next;
          }
          else
          {
            runner = runner.Next;
          }
        }
        current = current.Next;
      }
    }

    public static int KthToLast(Node head, int k)
    {
      Node current = head;
      int index = 0;
      while (current.Next != null)
      {
        current = current.Next;
        index++;
      }
      index -= k;
      for (int i = 0; i <= index; i++)
      {
        head = head.Next;
      }
      return head.Data;
    }
  }
}
