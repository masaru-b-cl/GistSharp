using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GistSharp.Test
{
  [TestClass]
  public class GistTest
  {
    /// <summary>
    ///Gist コンストラクター のテスト
    ///</summary>
    [TestMethod]
    public void TestGistConstructor()
    {
      var user = "user";
      var password = "password";
      TestingGist target = new TestingGist(user, password);

      Assert.AreEqual("user", target.User);
      Assert.AreEqual("password", target.Password);
    }

    [TestMethod]
    public void TestCreate()
    {
      var description = "description";
      var isPublic = true;
      var filename = "filename";
      var content = "content";

      var gist = new TestingGist("user", "password");

      gist.FuncOfPostGistsWeb = (_, __) =>
        {
          return @"{""html_url"":""https://gist.github.com/2006841"",""files"":{""file1.data"":{""content"":""IlN0cmluZyBmaWxlIGNvbnRlbnRz"",""type"":""text/plain"",""raw_url"":""https://gist.github.com/raw/2006841/354e931b43f921bd43abfff82004275472d49d6e/file1.data"",""language"":null,""size"":28,""filename"":""file1.data""}},""git_push_url"":""git@gist.github.com:2006841.git"",""forks"":[],""history"":[{""change_status"":{""additions"":1,""deletions"":0,""total"":1},""user"":{""login"":""masaru-b-cl"",""url"":""https://api.github.com/users/masaru-b-cl"",""gravatar_id"":""fee058832252e72722b8b03073ff6324"",""id"":781507,""avatar_url"":""https://secure.gravatar.com/avatar/fee058832252e72722b8b03073ff6324?d=https://a248.e.akamai.net/assets.github.com%2Fimages%2Fgravatars%2Fgravatar-140.png""},""url"":""https://api.github.com/gists/2006841/c5b7288be1fdb2bace1476d98df44609823aade0"",""committed_at"":""2012-03-09T14:53:05Z"",""version"":""c5b7288be1fdb2bace1476d98df44609823aade0""}],""public"":true,""comments"":0,""updated_at"":""2012-03-09T14:53:04Z"",""user"":{""login"":""masaru-b-cl"",""url"":""https://api.github.com/users/masaru-b-cl"",""gravatar_id"":""fee058832252e72722b8b03073ff6324"",""id"":781507,""avatar_url"":""https://secure.gravatar.com/avatar/fee058832252e72722b8b03073ff6324?d=https://a248.e.akamai.net/assets.github.com%2Fimages%2Fgravatars%2Fgravatar-140.png""},""url"":""https://api.github.com/gists/2006841"",""created_at"":""2012-03-09T14:53:04Z"",""id"":""2006841"",""description"":""the description for this gist"",""git_pull_url"":""git://gist.github.com/2006841.git""}";
        };
      var result = gist.Create(description, isPublic, filename, content);

      Assert.AreEqual("2006841", result.Id);
      Assert.AreEqual("https://gist.github.com/2006841", result.HtmlUrl);
      Assert.AreEqual("git://gist.github.com/2006841.git", result.GitPullUrl);
      Assert.AreEqual("git@gist.github.com:2006841.git", result.GitPushUrl);
    }

    /// <summary>
    ///CreateWebClient のテスト
    ///</summary>
    [TestMethod()]
    [DeploymentItem("GistSharp.dll")]
    public void CreateWebClientTest()
    {
      var user = "user";
      var password = "password";
      var gist = new Gist_Accessor(user, password);

      WebClient client = gist.CreateWebClient();
      var header = client.Headers["Authorization"];

      Assert.AreEqual("Basic dXNlcjpwYXNzd29yZA==", header);
    }

    [TestMethod]
    [DeploymentItem("GistSharp.dll")]
    public void TestCreateDataRaw()
    {
      var gist = new Gist_Accessor("", "");
      var result = gist.CreateDataRaw("description", true, "file1.txt", "content");

      Assert.AreEqual(@"{""description"":""description"",""public"":true,""files"":{""file1.txt"":{""content"":""content""}}}", result);
    }

    [TestMethod]
    [DeploymentItem("GistSharp.dll")]
    public void TestEscape()
    {
      Assert.AreEqual(@"\""", Gist_Accessor.Escape(@""""));
      Assert.AreEqual(@"\\", Gist_Accessor.Escape(@"\"));
      Assert.AreEqual(@"\n", Gist_Accessor.Escape(@"
"));
    }
  }
}
