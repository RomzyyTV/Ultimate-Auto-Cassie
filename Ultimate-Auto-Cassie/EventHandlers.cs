using Exiled.API.Features;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Exiled.API.Enums;
using Exiled.API.Features.Doors;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.EventArgs.Server;
using MEC;
using PlayerRoles;
using UnityEngine;
using Player = Exiled.Events.Handlers.Player;

namespace Ultimate_Auto_Cassie;
public class EventHandlers
{
    private CoroutineHandle _coroutine;
    public void OnRoundStarted()
    {
        _coroutine = Timing.RunCoroutine(Cassiee());
        foreach (Door door in Door.List.Where(o => o.Type == DoorType.Scp096))
        {
            door.KeycardPermissions = KeycardPermissions.Checkpoints;
        }
    }

    public void OnRoundEnded(RoundEndedEventArgs ev)
    {
        Timing.KillCoroutines(_coroutine);
    }

    public IEnumerator<float> Cassiee()
    {
        Timing.WaitForSeconds(15f);
        Cassie.MessageTranslated(Plugin.Singleton.Config.Cassie, Plugin.Singleton.Config.MessageTranslated, Plugin.Singleton.Config.IsHeld, Plugin.Singleton.Config.isNoisy, Plugin.Singleton.Config.IsSubtitles);
        Map.ChangeLightsColor(Color.blue);
        Timing.WaitForSeconds(8f);
        Map.ResetLightsColor();
        yield break;
    }

    public void OnPicupItem(PickingUpItemEventArgs ev)
    {
        if (ev.Player.Role.Type is RoleTypeId.Scientist)
        {
            if (ev.Pickup.Type is ItemType.GunCrossvec or ItemType.GunFRMG0)
            {
                ev.Player.ShowHint("<b>Les <color=#f7ff00>scientifiques</color> ne peuvent pas prendre ce type d'armes.</b>", 4f);
                ev.IsAllowed = false;
            }
        }
    }
}
