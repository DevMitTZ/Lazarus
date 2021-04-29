/* avoid cs0176 by making class public
 * Input.Parser inParse = new Input.Parser();
 * inParse.Main("test");
*/
using System;
namespace Lazarus
{
  class Program
  {
    static void Main()
    {
      bool running = true;
      Input.Parser inParser = new Input.Parser();
      PAP.PAP pap = new PAP.PAP();
      String state = "idle";
      while (running)
      {
        state = inParser.parse(Console.ReadLine()) ?? state;
        switch (state)
        {
          case "idle":
            //
            break;
          case "make":
            //
            break;
          case "run":
            if (!pap.hasPAP)
              pap.loadPAP();
            pap.run();
            break;
          case "quit":
            running = false;
            Console.WriteLine("quitting");
            break;
          default:
            throw new Exception("unknown state 🤷");
        }
      }
    }
  }
}
