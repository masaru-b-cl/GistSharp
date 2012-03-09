using System;
using System.Net;
using System.Text;
using Codeplex.Data;

namespace GistSharp
{
  public class Gist
  {
    private static readonly Encoding encoding = Encoding.UTF8;

    protected string user;
    protected string password;

    public Gist(string user, string password)
    {
      this.user = user;
      this.password = password;
    }

    public GistResult Create(string description, bool isPublic, string filename, string content)
    {
      using (var client = CreateWebClient())
      {
        var dataRaw = CreateDataRaw(description, isPublic, filename, content);
        var responseRaw = PostGists(client, dataRaw);
        dynamic response = DynamicJson.Parse(responseRaw);
        return new GistResult()
          {
            Id = response.id,
            HtmlUrl = response.html_url,
            GitPullUrl = response.git_pull_url,
            GitPushUrl = response.git_push_url,
          };
      }
    }

    protected virtual string PostGists(WebClient client, string dataRaw)
    {
      var data = encoding.GetBytes(dataRaw);
      var responseRaw = client.UploadData(@"https://api.github.com/gists", data);
      var json = encoding.GetString(responseRaw);
      return json;
    }

    private string CreateDataRaw(string description, bool isPublic, string filename, string content)
    {
      var dataRaw = @"{""description"":""" + description + @""","
        + @"""public"":" + isPublic.ToString().ToLower() + ","
        + @"""files"":{""" + filename + @""":{"
        + @"""content"":""" + Escape(content) + @"""}}}";
      return dataRaw;
    }

    private WebClient CreateWebClient()
    {
      var client = new WebClient();
      var credentials = Convert.ToBase64String(
            encoding.GetBytes(String.Format("{0}:{1}", user, password))
            );
      client.Headers["Authorization"] = String.Format("Basic {0}", credentials);
      return client;
    }


    private static string Escape(string value)
    {
      return value
        .Replace(@"\", @"\\")
        .Replace(@"""", @"\""")
        .Replace(@"
", @"\n")
        ;
    }
  }
}
