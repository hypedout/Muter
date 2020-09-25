using Muter.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Muter
{
  class ProcessIcon : IDisposable
  {
    public NotifyIcon _ntfIcon;

    public ProcessIcon()
    {
      _ntfIcon = new NotifyIcon();
    }

    /// <summary>
    /// Displays the icon in the system tray.
    /// </summary>
    public void Display()
    {
      // Put the icon in the system tray
      _ntfIcon.Icon = Resources.mute_grn;
      _ntfIcon.Text = "Muter";
      _ntfIcon.Visible = true;

      // Attach a context menu.
      _ntfIcon.ContextMenuStrip = new ContextMenus().Create();
    }

    ~ProcessIcon()
    {
      this.Dispose(false);
    }

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize(this);  // Finalization is now unnecessary
    }

    internal void ChangeIcon(bool started)
    {
      _ntfIcon.Icon = started ? Resources.mute_red : Resources.mute_grn;
    }

    protected virtual void Dispose(bool disposing)
    {
      if (disposing)
      {
        _ntfIcon.Dispose();
      }
    }
  }
}
