using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.Shell;
using System.ComponentModel;

namespace TAKANOSho.GistSharpExtension
{
  public class GistSharpExtensionOptionPage : DialogPage
  {
    [Category("GitHub account settings")]
    [DisplayName("User")]
    [Description("GitHub account user name.")]
    public string User { get; set; }

    [Category("GitHub account settings")]
    [DisplayName("Password")]
    [Description("GitHub account password.")]
    public string Password { get; set; }
  }
}
