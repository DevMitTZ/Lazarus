using System;
namespace Lazarus
{
  namespace Render
  {
    public class Compositer
    {
      private static int width = 80;
      private static int height = 24;
      private char[,] composter_buffer = new char[width, height];

      public Compositer()
      {
        for (int i = 0; i < width; i++)
        {
          for (int j = 0; j < height; j++)
          {
            composter_buffer[i, j] = ' ';
          }
        }
      }
      public void writeToBuffer(char c, int x, int y)
      {
        if (x >= 0 && x < width && y >= 0 && y < height)
        {
          composter_buffer[x, y] = c;
        }
      }
      public void printToScreen()
      {

        for (int i = 0; i < width; i++)
        {
          for (int j = 0; j < height; j++)
          {
            Console.SetCursorPosition(i, j);
            Console.Write(composter_buffer[i, j]);
          }
        }
      }
    }
  }
}