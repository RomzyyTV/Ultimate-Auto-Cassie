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

namespace Ultimate_Auto_Cassie;
public class UltimateAutoCassie : Plugin<Config>
{
    public override string Name => "Ultimate-Auto-Cassie";
    public override string Author => "By RomzyyTV";
    public override Version Version => new Version(1, 0, 0);
    public override Version RequiredExiledVersion { get; } = new(8, 11, 0);

    public override void OnEnabled()
    {
        Exiled.Events.Handlers.Server.RoundStarted += OnRoundStarted;
        Exiled.Events.Handlers.Server.RoundEnded += OnRoundEnded;
        Exiled.Events.Handlers.Player.PickingUpItem += OnPicupItem;
    }

    public override void OnDisabled() 
    {
    Exiled.Events.Handlers.Server.RoundStarted -= OnRoundStarted;
    Exiled.Events.Handlers.Server.RoundEnded -= OnRoundEnded;
    Exiled.Events.Handlers.Player.PickingUpItem -= OnPicupItem;
    }

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

    private IEnumerator<float> Cassiee()
    {
        Timing.WaitForSeconds(15f);
        Cassie.MessageTranslated(Config.Cassie, Config.MessageTranslated, Config.IsHeld, Config.isNoisy, Config.IsSubtitles);
        Map.ChangeLightsColor(Color.blue);
        Timing.WaitForSeconds(8f);
        Map.ResetLightsColor();
        yield break;
    }

    private void OnPicupItem(PickingUpItemEventArgs ev)
    {
        if (ev.Player.Role.Type is RoleTypeId.Scientist)
        {
            if (ev.Pickup.Type is ItemType.GunCrossvec or ItemType.GunFRMG0)
            {
                ev.Player.ShowHint(
                    "<b>Les <color=#f7ff00>scientifiques</color> ne peuvent pas prendre ce type d'armes.</b>", 4f);
                ev.IsAllowed = false;
            }
        }
    }
}
