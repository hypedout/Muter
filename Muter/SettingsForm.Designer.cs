namespace Muter
{
  partial class SettingsForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
      this.buttonOk = new System.Windows.Forms.Button();
      this.listBoxMuteTitles = new System.Windows.Forms.ListBox();
      this.buttonAdd = new System.Windows.Forms.Button();
      this.buttonDel = new System.Windows.Forms.Button();
      this.textBoxProcess = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.buttonEdit = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.numericUpDownInterval = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).BeginInit();
      this.SuspendLayout();
      // 
      // buttonOk
      // 
      this.buttonOk.Location = new System.Drawing.Point(449, 297);
      this.buttonOk.Name = "buttonOk";
      this.buttonOk.Size = new System.Drawing.Size(70, 35);
      this.buttonOk.TabIndex = 1;
      this.buttonOk.Text = "OK";
      this.buttonOk.UseVisualStyleBackColor = true;
      this.buttonOk.Click += new System.EventHandler(this.ButtonOK_Click);
      // 
      // listBoxMuteTitles
      // 
      this.listBoxMuteTitles.FormattingEnabled = true;
      this.listBoxMuteTitles.ItemHeight = 16;
      this.listBoxMuteTitles.Location = new System.Drawing.Point(22, 82);
      this.listBoxMuteTitles.Name = "listBoxMuteTitles";
      this.listBoxMuteTitles.Size = new System.Drawing.Size(412, 196);
      this.listBoxMuteTitles.TabIndex = 2;
      this.listBoxMuteTitles.SelectedIndexChanged += new System.EventHandler(this.ListBoxMuteTitles_SelectedIndexChanged);
      // 
      // buttonAdd
      // 
      this.buttonAdd.Location = new System.Drawing.Point(449, 82);
      this.buttonAdd.Name = "buttonAdd";
      this.buttonAdd.Size = new System.Drawing.Size(70, 40);
      this.buttonAdd.TabIndex = 3;
      this.buttonAdd.Text = "Add";
      this.buttonAdd.UseVisualStyleBackColor = true;
      this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
      // 
      // buttonDel
      // 
      this.buttonDel.Location = new System.Drawing.Point(449, 174);
      this.buttonDel.Name = "buttonDel";
      this.buttonDel.Size = new System.Drawing.Size(70, 40);
      this.buttonDel.TabIndex = 4;
      this.buttonDel.Text = "Delete";
      this.buttonDel.UseVisualStyleBackColor = true;
      this.buttonDel.Click += new System.EventHandler(this.ButtonDel_Click);
      // 
      // textBoxProcess
      // 
      this.textBoxProcess.Location = new System.Drawing.Point(128, 20);
      this.textBoxProcess.Name = "textBoxProcess";
      this.textBoxProcess.Size = new System.Drawing.Size(306, 22);
      this.textBoxProcess.TabIndex = 5;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(19, 23);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(102, 17);
      this.label1.TabIndex = 6;
      this.label1.Text = "Process name:";
      // 
      // buttonEdit
      // 
      this.buttonEdit.Location = new System.Drawing.Point(449, 128);
      this.buttonEdit.Name = "buttonEdit";
      this.buttonEdit.Size = new System.Drawing.Size(70, 40);
      this.buttonEdit.TabIndex = 7;
      this.buttonEdit.Text = "Edit";
      this.buttonEdit.UseVisualStyleBackColor = true;
      this.buttonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(19, 58);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(94, 17);
      this.label2.TabIndex = 8;
      this.label2.Text = "Window titles:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(19, 299);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(77, 17);
      this.label3.TabIndex = 9;
      this.label3.Text = "Interval [s]:";
      // 
      // numericUpDownInterval
      // 
      this.numericUpDownInterval.Location = new System.Drawing.Point(103, 297);
      this.numericUpDownInterval.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.numericUpDownInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericUpDownInterval.Name = "numericUpDownInterval";
      this.numericUpDownInterval.Size = new System.Drawing.Size(44, 22);
      this.numericUpDownInterval.TabIndex = 10;
      this.numericUpDownInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // SettingsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(531, 353);
      this.Controls.Add(this.numericUpDownInterval);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.buttonEdit);
      this.Controls.Add(this.textBoxProcess);
      this.Controls.Add(this.buttonDel);
      this.Controls.Add(this.buttonAdd);
      this.Controls.Add(this.listBoxMuteTitles);
      this.Controls.Add(this.buttonOk);
      this.Controls.Add(this.label1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "SettingsForm";
      this.Text = "Settings";
      this.Load += new System.EventHandler(this.SettingsForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button buttonOk;
    private System.Windows.Forms.ListBox listBoxMuteTitles;
    private System.Windows.Forms.Button buttonAdd;
    private System.Windows.Forms.Button buttonDel;
    private System.Windows.Forms.TextBox textBoxProcess;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button buttonEdit;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.NumericUpDown numericUpDownInterval;
  }
}