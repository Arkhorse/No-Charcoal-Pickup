using ModSettings;

namespace NoCharcoalPickup
{
    internal class NoCharcoalPickupSettings : JsonModSettings
    {
        [Section("General")]
        [Name("Enable Forced Pickup")]
        [Description("Vanilla = true")]
        public bool ForcePickup = false;

        [Name("Enable Forced Immediate Pickup")]
        [Description("Vanilla = true")]
        public bool ForceImmediatePickup = true;

        [Name("Skip Audio")]
        [Description("Vanilla = false")]
        public bool SkipAudio = false;
    }
    internal static class NoPickupSettings
    {
        internal static NoCharcoalPickupSettings ModSettings = new();
        public static void OnLoad()
        {
            ModSettings.AddToModSettings("No Charcoal Pickup");
        }
        internal static NoCharcoalPickupSettings Get()
        {
            return ModSettings;
        }
    }
}
