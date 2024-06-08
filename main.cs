using System;

class Program {
  public static void Main (string[] args) {

    var post = Console.ReadLine();

    if(post.Length > 140)
    {
      Console.WriteLine("Rejected");
    }
    else
    {
      Console.WriteLine("Posted");
    }
  }
}