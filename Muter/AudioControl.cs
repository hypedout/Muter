using AudioSwitcher.AudioApi;
using AudioSwitcher.AudioApi.CoreAudio;
using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Muter
{
  class AudioControl
  {
    private readonly CoreAudioDevice _device;
    private bool? _initiallyMuted;

    public AudioControl()
    {
      var controller = new CoreAudioController();
      _device = controller.GetDefaultDevice(DeviceType.Playback, Role.Multimedia);
    }

    public void Mute()
    {
      if (!_initiallyMuted.HasValue)
      {
        _initiallyMuted = _device.IsMuted;
      }

      if (!_initiallyMuted.GetValueOrDefault(true))
      {
        _device.Mute(true);
      }
    }

    public void Restore()
    {
      if (!_initiallyMuted.GetValueOrDefault(true))
      {
        _device.Mute(false);
      }

      _initiallyMuted = null;
    }
  }

}
