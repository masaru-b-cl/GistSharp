using System;
using System.Net;

namespace GistSharp.Test
{
  class TestingGist : Gist
  {
    public TestingGist(string user, string password)
      : base(user, password)
    {
    }

    public string User
    {
      get
      {
        return this.user;
      }
    }

    public string Password
    {
      get
      {
        return this.password;
      }
    }

    public Func<WebClient, string, string> FuncOfPostGistsWeb { get; set; }
    protected override string PostGists(WebClient client, string dataRaw)
    {
      return FuncOfPostGistsWeb(client, dataRaw);
    }
  }
}
