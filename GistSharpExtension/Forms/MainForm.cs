using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using GistSharp;
using System.Diagnostics;

namespace TAKANOSho.GistSharpExtension
{
  public partial class MainForm : Form
  {
    private MainFormViewModel vm = new MainFormViewModel();
    private string fullname;
    public MainForm()
    {
      InitializeComponent();

      vm.User = Properties.Settings.Default.User;
    }

    public MainForm(string fullname)
      : this()
    {
      this.fullname = fullname;
      var filename = Path.GetFileName(fullname);
      vm.Filename = filename;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      var content = File.ReadAllText(fullname);
      var gist = new Gist(vm.User, vm.Password);
      var result = gist.Create(vm.Description, vm.IsPublic, vm.Filename, content);

      Process.Start(result.HtmlUrl);

      Properties.Settings.Default.User = vm.User;

      this.Close();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      mainFormViewModelBindingSource.DataSource = vm;
    }
  }
}
