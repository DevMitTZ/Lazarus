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
      Render.Compositer compositer = new Render.Compositer();
      PAP.PAP pap = new PAP.PAP();

      bool _running = true;
      String _state = "idle";
      String _command = "";

      while (_running)
      {
        switch (_state)
        {
          case "idle":
            switch (Console.ReadKey().KeyChar)
            {
              case ':':
                _state = "cmd";
                _command = "";
                break;

              case 'w':
                break;

              case 'a':
                break;

              case 's':
                break;

              case 'd':
                break;
            }

            break;

          case "cmd":
            char c = Console.ReadKey().KeyChar;
            if (c == '\n')
            {
              string[] split_command = _command.Split(' ');
              switch (split_command[0])
              {
                case ":q":
                  _state = "quit";
                  break;

                case ":add":
                  switch (split_command[1])
                  {
                    case "write":
                    case "w":
                      _state = "add_w";
                      break;

                    case "prompt":
                    case "p":
                      _state = "add_p";
                      break;

                    case "compare":
                    case "cmp":
                    case "c":
                      _state = "add_c";
                      break;
                  }
                  break;

                default:
                  break;
              }

            }
            else
            {
              _command += c;
            }
            break;

          case "add_w":
            break;

          case "add_p":
            break;

          case "add_c":
            break;

          case "run":
            if (!pap.hasPAP)
              pap.loadPAP();

            pap.run();
            break;

          case "quit":
            _running = false;
            Console.WriteLine("quitting");
            break;

          default:
            throw new Exception("unknown state 🤷");
        }
      }
    }
  }
}
