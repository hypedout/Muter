using System;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Muter
{
  public class ActionStateChangedEventArgs : EventArgs
  {
    public bool Started { get; set; }
    public ActionStateChangedEventArgs(bool started)
    {
      Started = started;
    }
  }

  class ProcessMonitor
  {
    private const int _msecPerSecond = 1000;
    private readonly System.Timers.Timer _timer;
    private readonly AudioControl _audioControl;
    public event EventHandler<ActionStateChangedEventArgs> ActionStateChanged;

    public ProcessMonitor()
    {
      _timer = new System.Timers.Timer();
      _audioControl = new AudioControl();
    }

    public void Start()
    {
      if (_timer != null)
      {
        _timer.Interval = Properties.Settings.Default.Interval * _msecPerSecond;
        _timer.Elapsed += OnTimedEvent;
        _timer.AutoReset = true;
        _timer.Enabled = true;
      }
    }

    public void Stop()
    {
      if (_timer != null)
      {
        _timer.Enabled = false;
      }
    }

    public void CheckProcesses()
    {
      string selectprocess = Properties.Settings.Default.Process;
      Process[] processlist = Process.GetProcessesByName(selectprocess);

      var winTitle = processlist.Where(p => !String.IsNullOrEmpty(p.MainWindowTitle)).Select(p => p.MainWindowTitle).FirstOrDefault();
      Console.WriteLine($"[{winTitle??"-"}]");

      bool exexuteAction = false;
      if (!String.IsNullOrEmpty(winTitle))
      {
        exexuteAction = Properties.Settings.Default.ListMuteTitles.Contains(winTitle);
      }

      if (exexuteAction)
      {
        StartAction();
      }
      else
      {
        RestoreAction();
      }

      CheckIntervalHasChanged();
    }

    protected virtual void OnActionStateChanged(ActionStateChangedEventArgs e) => ActionStateChanged?.Invoke(this, e);

    private void StartAction()
    {
      OnActionStateChanged(new ActionStateChangedEventArgs(true));
      _audioControl.Mute();
    }

    private void RestoreAction()
    {
      OnActionStateChanged(new ActionStateChangedEventArgs(false));
      _audioControl.Restore();
    }

    private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e) => CheckProcesses();

    private void CheckIntervalHasChanged()
    {
      if (_timer.Interval != Properties.Settings.Default.Interval * _msecPerSecond)
      {
        Debug.WriteLine($"Change interval from {_timer.Interval} to {Properties.Settings.Default.Interval}[s]");
        _timer.Stop();
        _timer.Interval = Properties.Settings.Default.Interval * _msecPerSecond;
        _timer.Start();
      }
    }
  }

}
