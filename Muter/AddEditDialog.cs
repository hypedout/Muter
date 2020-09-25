using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muter
{
  public partial class AddEditDialog : Form
  {
    public AddEditDialog()
    {
      InitializeComponent();
      textBoxItem.Focus();
    }

    public AddEditDialog(string item)
    {
      InitializeComponent();
      textBoxItem.Text = item;
      textBoxItem.Focus();
    }

    public string GetItem()
    {
      return textBoxItem.Text;
    }
  }
}
