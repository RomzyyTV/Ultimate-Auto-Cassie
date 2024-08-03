using Exiled.API.Features;
using System;

namespace Ultimate_Auto_Cassie
{
    public class UltimateAutoCassie : Plugin<Config>
    {
        public override string Name => "Ultimate-Auto-Cassie";
        public override string Author => "By RomzyyTV";
        public override Version Version => new Version(1, 0, 0);

        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Server.RoundStarted += Onroundstarted;
        }

        public override void OnDisabled() 
        {
        Exiled.Events.Handlers.Server.RoundStarted -= Onroundstarted;
        }

        private void Onroundstarted()
        {
            Cassie.MessageTranslated(Config.Cassie, Config.MessageTranslated, Config.IsHeld, Config.isNoisy, Config.IsSubtitles);
            Map.TurnOffAllLights(Config.BlackOut);
        }
    }
}
