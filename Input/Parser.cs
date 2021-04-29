using System;
namespace Lazarus
{
  namespace Input
  {
    public class Parser
    {
      public string parse(String Input)
      {
        string newState = null;
        Console.WriteLine($"received {Input} as input");
        if (Input.ToLower() == ":q")
          newState = "quit";
        return newState;
      }
    }
  }
}