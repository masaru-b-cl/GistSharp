namespace TAKANOSho.GistSharpExtension
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.Label descriptionLabel;
      System.Windows.Forms.Label filenameLabel;
      System.Windows.Forms.Label isPublicLabel;
      System.Windows.Forms.Label passwordLabel;
      System.Windows.Forms.Label userLabel;
      this.button1 = new System.Windows.Forms.Button();
      this.descriptionTextBox = new System.Windows.Forms.TextBox();
      this.filenameTextBox = new System.Windows.Forms.TextBox();
      this.isPublicCheckBox = new System.Windows.Forms.CheckBox();
      this.passwordTextBox = new System.Windows.Forms.TextBox();
      this.userTextBox = new System.Windows.Forms.TextBox();
      this.mainFormViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
      descriptionLabel = new System.Windows.Forms.Label();
      filenameLabel = new System.Windows.Forms.Label();
      isPublicLabel = new System.Windows.Forms.Label();
      passwordLabel = new System.Windows.Forms.Label();
      userLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.mainFormViewModelBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // descriptionLabel
      // 
      descriptionLabel.AutoSize = true;
      descriptionLabel.Location = new System.Drawing.Point(35, 26);
      descriptionLabel.Name = "descriptionLabel";
      descriptionLabel.Size = new System.Drawing.Size(65, 12);
      descriptionLabel.TabIndex = 13;
      descriptionLabel.Text = "Description:";
      // 
      // filenameLabel
      // 
      filenameLabel.AutoSize = true;
      filenameLabel.Location = new System.Drawing.Point(35, 81);
      filenameLabel.Name = "filenameLabel";
      filenameLabel.Size = new System.Drawing.Size(53, 12);
      filenameLabel.TabIndex = 16;
      filenameLabel.Text = "Filename:";
      // 
      // isPublicLabel
      // 
      isPublicLabel.AutoSize = true;
      isPublicLabel.Location = new System.Drawing.Point(35, 53);
      isPublicLabel.Name = "isPublicLabel";
      isPublicLabel.Size = new System.Drawing.Size(38, 12);
      isPublicLabel.TabIndex = 18;
      isPublicLabel.Text = "Public:";
      // 
      // passwordLabel
      // 
      passwordLabel.AutoSize = true;
      passwordLabel.Location = new System.Drawing.Point(35, 156);
      passwordLabel.Name = "passwordLabel";
      passwordLabel.Size = new System.Drawing.Size(56, 12);
      passwordLabel.TabIndex = 19;
      passwordLabel.Text = "Password:";
      // 
      // userLabel
      // 
      userLabel.AutoSize = true;
      userLabel.Location = new System.Drawing.Point(35, 131);
      userLabel.Name = "userLabel";
      userLabel.Size = new System.Drawing.Size(31, 12);
      userLabel.TabIndex = 20;
      userLabel.Text = "User:";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(106, 191);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(137, 23);
      this.button1.TabIndex = 5;
      this.button1.Text = "Create new gist";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // descriptionTextBox
      // 
      this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mainFormViewModelBindingSource, "Description", true));
      this.descriptionTextBox.Location = new System.Drawing.Point(106, 23);
      this.descriptionTextBox.Name = "descriptionTextBox";
      this.descriptionTextBox.Size = new System.Drawing.Size(432, 19);
      this.descriptionTextBox.TabIndex = 0;
      // 
      // filenameTextBox
      // 
      this.filenameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mainFormViewModelBindingSource, "Filename", true));
      this.filenameTextBox.Location = new System.Drawing.Point(106, 78);
      this.filenameTextBox.Name = "filenameTextBox";
      this.filenameTextBox.Size = new System.Drawing.Size(178, 19);
      this.filenameTextBox.TabIndex = 2;
      // 
      // isPublicCheckBox
      // 
      this.isPublicCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.mainFormViewModelBindingSource, "IsPublic", true));
      this.isPublicCheckBox.Location = new System.Drawing.Point(106, 48);
      this.isPublicCheckBox.Name = "isPublicCheckBox";
      this.isPublicCheckBox.Size = new System.Drawing.Size(104, 24);
      this.isPublicCheckBox.TabIndex = 1;
      this.isPublicCheckBox.UseVisualStyleBackColor = true;
      // 
      // passwordTextBox
      // 
      this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mainFormViewModelBindingSource, "Password", true));
      this.passwordTextBox.Location = new System.Drawing.Point(106, 153);
      this.passwordTextBox.Name = "passwordTextBox";
      this.passwordTextBox.Size = new System.Drawing.Size(104, 19);
      this.passwordTextBox.TabIndex = 4;
      // 
      // userTextBox
      // 
      this.userTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mainFormViewModelBindingSource, "User", true));
      this.userTextBox.Location = new System.Drawing.Point(106, 128);
      this.userTextBox.Name = "userTextBox";
      this.userTextBox.Size = new System.Drawing.Size(104, 19);
      this.userTextBox.TabIndex = 3;
      // 
      // mainFormViewModelBindingSource
      // 
      this.mainFormViewModelBindingSource.DataSource = typeof(TAKANOSho.GistSharpExtension.MainFormViewModel);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(573, 236);
      this.Controls.Add(this.button1);
      this.Controls.Add(descriptionLabel);
      this.Controls.Add(this.descriptionTextBox);
      this.Controls.Add(filenameLabel);
      this.Controls.Add(this.filenameTextBox);
      this.Controls.Add(isPublicLabel);
      this.Controls.Add(this.isPublicCheckBox);
      this.Controls.Add(passwordLabel);
      this.Controls.Add(this.passwordTextBox);
      this.Controls.Add(userLabel);
      this.Controls.Add(this.userTextBox);
      this.Name = "MainForm";
      this.Text = "MainForm";
      this.Load += new System.EventHandler(this.MainForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.mainFormViewModelBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.BindingSource mainFormViewModelBindingSource;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox descriptionTextBox;
    private System.Windows.Forms.TextBox filenameTextBox;
    private System.Windows.Forms.CheckBox isPublicCheckBox;
    private System.Windows.Forms.TextBox passwordTextBox;
    private System.Windows.Forms.TextBox userTextBox;
  }
}