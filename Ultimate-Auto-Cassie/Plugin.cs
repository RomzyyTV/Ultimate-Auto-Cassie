using Exiled.API.Features;
using System;

namespace Ultimate_Auto_Cassie;

public class Plugin : Plugin<Config>
{
    public override string Name => "Ultimate-Auto-Cassie";
    public override Version Version => new Version(1, 1, 0);
    public static Plugin Singleton;
    public static EventHandlers Handlers;

    public override void OnEnabled()
    {
        Exiled.Events.Handlers.Server.RoundStarted += Handlers.OnRoundStarted;
        Exiled.Events.Handlers.Server.RoundEnded += Handlers.OnRoundEnded;
        base.OnEnabled();
    }

    public override void OnDisabled() 
    {
        Exiled.Events.Handlers.Server.RoundStarted -= Handlers.OnRoundStarted;
        Exiled.Events.Handlers.Server.RoundEnded -= Handlers.OnRoundEnded;
        base.OnDisabled();
    }
}