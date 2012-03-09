using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TAKANOSho.GistSharpExtension
{
  public class MainFormViewModel
  {
    public string Description { get; set; }
    public bool IsPublic { get; set; }
    public string Filename { get; set; }
    public string User { get; set; }
    public string Password { get; set; }
  }
}
