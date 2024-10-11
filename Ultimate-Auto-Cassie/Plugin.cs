using Exiled.API.Features;

namespace Ultimate_Auto_Cassie;

public class Plugin : Plugin<Config>
{
    public override string Name => "Ultimate-Auto-Cassie";
    public override Version Version => new Version(1, 1, 0);
    public static Plugin Singleton;

    public override void OnEnabled()
    {
        base.OnEnabled();
    }

    public override void OnDisabled() 
    {
        base.OnDisabled();
    }
}