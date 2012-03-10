using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using GistSharp;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using TAKANOSho.GistSharpExtension;

namespace CreateNewGist
{
  class Program
  {
    static int Main(string[] args)
    {
      if (args.Length == 0)
      {
        MessageBox.Show("Gistに登録したいファイルのパスをコマンドライン引数として指定してください。");
        return -1;
      }

      var path = args[0];

      if (!File.Exists(path))
      {
        MessageBox.Show("存在するファイルのパスを指定してください。");
        return -1;
      }

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new MainForm(path));

      return 0;
    }
  }
}
