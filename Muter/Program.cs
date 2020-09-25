using System;
using System.Windows.Forms;

namespace Muter
{
  static class Program
  {
    private static ProcessIcon _processIcon;

    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      using (_processIcon = new ProcessIcon())
      {
        _processIcon.Display();

        var pm = new ProcessMonitor();
        pm.ActionStateChanged += HandleActionStateChangedEvent;
        pm.Start();

        Application.Run();
      }
    }

    static void HandleActionStateChangedEvent(object sender, ActionStateChangedEventArgs e)
    {
      Console.WriteLine($"==> {e.Started}");
      _processIcon.ChangeIcon(e.Started);
    }
  }

}
