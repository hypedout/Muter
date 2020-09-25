using System;
using System.Drawing;
using System.Windows.Forms;

namespace Muter
{
  public partial class SettingsForm : Form
  {
    public SettingsForm()
    {
      InitializeComponent();
      var workingArea = Screen.GetWorkingArea(this);
      this.Location = new Point(workingArea.Right - Size.Width, workingArea.Bottom - Size.Height);
    }

    private void ButtonOK_Click(object sender, EventArgs e)
    {
      Properties.Settings.Default.Process = textBoxProcess.Text;
      
      Properties.Settings.Default.ListMuteTitles.Clear();
      foreach (var item in listBoxMuteTitles.Items)
      {
        Properties.Settings.Default.ListMuteTitles.Add(item.ToString());
      }

      Properties.Settings.Default.Interval = (uint)numericUpDownInterval.Value;

      Properties.Settings.Default.Save();
      this.Close();
    }

    private void SettingsForm_Load(object sender, EventArgs e)
    {
      textBoxProcess.Text = Properties.Settings.Default.Process;

      listBoxMuteTitles.Items.Clear();
      foreach (var title in Properties.Settings.Default.ListMuteTitles)
      {
        listBoxMuteTitles.Items.Add(title);
      }

      numericUpDownInterval.Value = Properties.Settings.Default.Interval;
    }

    private void ButtonAdd_Click(object sender, EventArgs e)
    {
      var dlg = new AddEditDialog();
      dlg.Text = "Add";
      dlg.ShowDialog();
      if (dlg.DialogResult == DialogResult.OK)
      {
        var item = dlg.GetItem();
        if (!String.IsNullOrEmpty(item))
        {
          listBoxMuteTitles.SelectedIndex = listBoxMuteTitles.Items.Add(item);
        }
      }
      dlg.Dispose();
    }

    private void ButtonEdit_Click(object sender, EventArgs e)
    {
      var dlg = new AddEditDialog(listBoxMuteTitles.SelectedItem.ToString());
      dlg.Text = "Edit";
      dlg.ShowDialog();
      if (dlg.DialogResult == DialogResult.OK)
      {
        var item = dlg.GetItem();
        if (!String.IsNullOrEmpty(item))
        {
          listBoxMuteTitles.Items[listBoxMuteTitles.SelectedIndex] = item;
        }
      }
      dlg.Dispose();
    }

    private void ButtonDel_Click(object sender, EventArgs e)
    {
      int idx = listBoxMuteTitles.SelectedIndex;
      listBoxMuteTitles.Items.RemoveAt(idx);
      if (listBoxMuteTitles.Items.Count > 0)
      {
        listBoxMuteTitles.SetSelected((idx > 0) ? (idx - 1) : idx, true);
      }
    }

    private void ListBoxMuteTitles_SelectedIndexChanged(object sender, EventArgs e)
    {
      buttonDel.Enabled = (listBoxMuteTitles.SelectedIndex > -1);
    }
  }
}
