using Exiled.API.Features;
using System.Collections.Generic;
using Exiled.Events.EventArgs.Server;
using MEC;
using UnityEngine;

namespace Ultimate_Auto_Cassie;
public class EventHandlers
{
    private CoroutineHandle _coroutine;
    public void OnRoundStarted()
    {
        _coroutine = Timing.RunCoroutine(Cassiee());
    }

    public void OnRoundEnded(RoundEndedEventArgs ev)
    {
        Timing.KillCoroutines(_coroutine);
    }

    private IEnumerator<float> Cassiee()
    {
        yield return Timing.WaitForSeconds(15f);
        Cassie.MessageTranslated(Plugin.Singleton.Config.Cassie, Plugin.Singleton.Config.MessageTranslated, Plugin.Singleton.Config.IsHeld, Plugin.Singleton.Config.isNoisy, Plugin.Singleton.Config.IsSubtitles);
        Map.ChangeLightsColor(Color.blue);
        yield return Timing.WaitForSeconds(8f);
        Map.ResetLightsColor();
        yield break;
    }
}
