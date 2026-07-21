using System;
using System.IO;
using System.Text;
using FirstExcercise.Utility; 

namespace FirstExcercise 
{

  class FirstPuzzle
  {
    static void Main(string[] args)
    {

      Utilidades utils = new Utilidades();

      try
      {
        using (FileStream fs = File.Open("./input.txt", FileMode.Open, FileAccess.Read, FileShare.None))
        {
          byte[] b = new byte[1024];
          UTF8Encoding temp = new UTF8Encoding(true);

          while ( fs.Read(b,0,b.Length) > 0)
          {
            Console.WriteLine(temp.GetString(b));
          }
          utils.saludar();

        }
      }
      catch {
            Console.WriteLine("error trying to open a file");
      }
    }
  }
}
