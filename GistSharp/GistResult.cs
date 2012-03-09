using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GistSharp
{
  public class GistResult
  {
    public string Id { get; set; }

    public string HtmlUrl { get; set; }

    public string GitPullUrl { get; set; }

    public string GitPushUrl { get; set; }
  }
}
