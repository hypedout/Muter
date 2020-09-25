using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Muter
{
  class ContextMenus
  {
//    bool isAboutLoaded = false;

    public ContextMenuStrip Create()
    {
      // Add the default menu options.
      ContextMenuStrip menu = new ContextMenuStrip();
      ToolStripMenuItem item;

      // Windows Explorer.
      item = new ToolStripMenuItem();
      item.Text = "Setting";
      item.Click += new EventHandler(Settings_Click);
//      item.Image = Resources.Explorer;
      menu.Items.Add(item);

//      // About.
//      item = new ToolStripMenuItem();
//      item.Text = "About";
//      item.Click += new EventHandler(About_Click);
////      item.Image = Resources.About;
//      menu.Items.Add(item);

      // Separator.
      ToolStripSeparator sep = new ToolStripSeparator();
      menu.Items.Add(sep);

      // Exit.
      item = new ToolStripMenuItem();
      item.Text = "Exit";
      item.Click += new System.EventHandler(Exit_Click);
//      item.Image = Resources.Exit;
      menu.Items.Add(item);

      return menu;
    }

    void Settings_Click(object sender, EventArgs e)
    {
      var settingForm = new SettingsForm();
      settingForm.ShowDialog();
    }

    //void About_Click(object sender, EventArgs e)
    //{
    //  if (!isAboutLoaded)
    //  {
    //    isAboutLoaded = true;
    //    new AboutBox().ShowDialog();
    //    isAboutLoaded = false;
    //  }
    //}

    void Exit_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
  }
}