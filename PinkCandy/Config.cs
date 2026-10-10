using Exiled.API.Interfaces;
using System.ComponentModel;

namespace PinkCandy
{
    public sealed class Config : IConfig
    {
        [Description("Enable the PinkCandy plugin")]
        public bool IsEnabled {  get; set; } = true;
        [Description("Enable PinkCandy debug mode")]
        public bool Debug { get; set; } = true;
        [Description("Pink candy spawn chance [1/value]")]
        public ushort SpawnPinkCandy = 20;
    }
}
