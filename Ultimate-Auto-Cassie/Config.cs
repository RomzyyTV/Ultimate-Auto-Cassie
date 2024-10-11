using Exiled.API.Interfaces;
using System.ComponentModel;

namespace Ultimate_Auto_Cassie
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;

        [Description("Cassie is not message translated in french")]
        public string Cassie { get; set; } = "pitch_1.0 warning pitch_0.2 .g4 .g4 \npitch_0.9 The site is experiencing many Keter and Euclid level containment breaches, full site unlock down initiated, please evacuation gate B. pitch_0.05 .g7";

        [Description("Cassie message translated in frech is not Cassie in english")]
        public string MessageTranslated { get; set; } = "Warning, \nLe site connaît de nombreuses violations de confinement au niveau Keter et Euclide, déverrouillage complet du site initié, veuillez évacuer par la gate B.";

        [Description("Is held")]
        public bool IsHeld { get; set; } = false;

        [Description("Is Noisy")]
        public bool isNoisy { get; set; } = false;

        [Description("Is Subtitles")]
        public bool IsSubtitles { get; set; } = true;
        
        [Description("Timing wait before Cassie Message")]
        public float CassieMessageDelay { get; set; } = 15f;
        
        [Description("Timing wait before Reset light color")]
        public float TimingResetLightColor { get; set; } = 8f;
    }
}