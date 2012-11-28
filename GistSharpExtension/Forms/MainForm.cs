using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using GistSharp;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;

namespace TAKANOSho.GistSharpExtension
{
  public partial class MainForm : Form
  {
    private MainFormViewModel vm = new MainFormViewModel() { IsPublic = true };
    private string fullname;

    public MainForm(string fullname)
      : this(fullname, "", "")
    {
    }

    public MainForm(string fullname, string user, string password)
    {
      InitializeComponent();

      this.fullname = fullname;
      var filename = Path.GetFileName(fullname);
      vm.Filename = filename;

      vm.User = user;
      vm.Password = password;
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      mainFormViewModelBindingSource.DataSource = vm;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      CreateNewGist();
    }

    private void MainForm_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.Control && e.KeyCode == Keys.Enter)
      {
        CreateNewGist();
      }
    }

    private void CreateNewGist()
    {
      try
      {
        this.Cursor = Cursors.WaitCursor;

        try
        {
          var content = File.ReadAllText(fullname);
          var gist = new Gist(vm.User, vm.Password);
          var result = gist.Create(vm.Description, vm.IsPublic, vm.Filename, content);
          Process process = Process.Start(result.HtmlUrl);
          if (process != null)
          {
            process.WaitForInputIdle();
          }

          this.Close();
        }
        catch (WebException ex)
        {
          MessageBox.Show(ex.Message);
        }
      }
      finally
      {
        this.Cursor = Cursors.Default;
      }
    }

  }
}
