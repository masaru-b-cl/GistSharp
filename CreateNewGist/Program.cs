using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using GistSharp;
using System.Diagnostics;
using System.Net;

namespace CreateNewGist
{
  class Program
  {
    static void Main(string[] args)
    {
      if (args.Length == 0)
      {
        throw new ArgumentException("Gistに登録したいファイルのパスをコマンドライン引数として指定してください。");
      }

      var path = args[0];

      if (!File.Exists(path))
      {
        throw new ArgumentException("存在するファイルのパスを指定してください。");
      }
      var content = File.ReadAllText(path);

      Console.WriteLine("Please input description:");
      var description = Console.ReadLine();

      bool? isPublic = null;
      do
      {
        Console.WriteLine("Please input public yes/no (using \"yes\" when not input):");
        var @public = Console.ReadLine();

        if (String.IsNullOrEmpty(@public) || @public == "yes")
        {
          isPublic = true;
        }
        else if (@public == "no")
        {
          isPublic = false;
        }
      } while (!isPublic.HasValue);

      Console.WriteLine("Please input filename (using \"" + Path.GetFileName(path) + "\" if filename is not input):");
      var filename = Console.ReadLine();
      if (String.IsNullOrEmpty(filename))
      {
        filename = Path.GetFileName(path);
      }

      Console.WriteLine("Please input user:");
      var user = Console.ReadLine();

      Console.WriteLine("Please input password:");
      var password = Console.ReadLine();

      var gist = new Gist(user, password);
      try
      {
        var result = gist.Create(description, isPublic.Value, filename, content);
        var process = Process.Start(result.HtmlUrl);
        if (process != null)
        {
          process.WaitForExit();
        }
      }
      catch (WebException ex)
      {
        Console.WriteLine(ex.Message);
      }

      Console.WriteLine("終了するには何かキーを押してください...");
      Console.ReadKey();
    }
  }
}
