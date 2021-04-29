using System.Collections.Generic;
namespace Lazarus
{
  namespace PAP
  {
    public class PAP
    {
      public bool hasPAP = false;
      public List<Node> nodes = new List<Node>();
      private Loader loader = new Loader();
      private Interpreter interpreter = new Interpreter();
      public void loadPAP()
      {
        nodes = loader.load();
        hasPAP = true;
      }
      public void run()
      {
        interpreter.interpret(nodes);
      }
    }
  }
}