using Exiled.API.Features;
using System;

namespace Ultimate_Auto_Cassie;

public class Plugin : Plugin<Config>
{
    public override string Name => "Ultimate-Auto-Cassie";
    public override string Author => "By RomzyyTV";
    public override Version Version => new Version(1, 1, 0);
    public override Version RequiredExiledVersion { get; } = new(8, 11, 0);
    public static Plugin Singleton;
    public static EventHandlers Eventhandlers;
    
    public override void OnEnabled()
    {
        Singleton = this;
        Eventhandlers = new EventHandlers();
        
        Exiled.Events.Handlers.Server.RoundStarted += Eventhandlers.OnRoundStarted;
        Exiled.Events.Handlers.Server.RoundEnded += Eventhandlers.OnRoundEnded;
        Exiled.Events.Handlers.Player.PickingUpItem += Eventhandlers.OnPicupItem;
        base.OnEnabled();
    }

    public override void OnDisabled() 
    {
        Singleton = null;
        Eventhandlers = null;
        
        Exiled.Events.Handlers.Server.RoundStarted -= Eventhandlers.OnRoundStarted;
        Exiled.Events.Handlers.Server.RoundEnded -= Eventhandlers.OnRoundEnded;
        Exiled.Events.Handlers.Player.PickingUpItem -= Eventhandlers.OnPicupItem;
        base.OnDisabled();
    }
}