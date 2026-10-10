using Exiled.API.Features;
using System;

namespace PinkCandy
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin PinkCandyPlugin { get; } = new Plugin();
        public override string Author { get; } = "Steve";
        public override string Name { get; } = "PinkCandy";
        public override Version Version { get; } = new Version(0, 0, 0, 1);
        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Scp330.InteractingScp330 += EventHandlers.OnInteractingScp330;
            Log.Info("PinkCandy plugin loaded! By Steve [Open source on GitHub, copyright Steve]");
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Scp330.InteractingScp330 -= EventHandlers.OnInteractingScp330;
            Log.Info("PinkCandy plugin disabled!");
            base.OnDisabled();
        }
    }
}
