using HarmonyLib;
using Il2Cpp;
using MelonLoader;
using System.Reflection;
#pragma warning disable IDE0051 // Remove unused private members
namespace NoCharcoalPickup
{
    using Settings = NoPickupSettings;
    [HarmonyPatch(typeof(PlayerManager), "ProcessPickupItemInteraction", new Type[] { typeof(GearItem), typeof(bool), typeof(bool), typeof(bool) })]
    internal static class PlayerManager_ProcessPickupItemInteraction
    {
        //internal static CharcoalItem _CharcoalItem = new();
        internal static string ModName = $"{Assembly.GetExecutingAssembly().GetName().Name}";
        //internal static bool LOGGED = false;
        private static bool Prefix(GearItem item, bool forceEquip, bool forceEquipImmediate, bool skipAudio)
        {
            if ( item.name.Contains("Charcoal") )
            {
#if DEBUG
                MelonLogger.Msg($"[{ModName}]: Item picked up, is Charcoal");
                MelonLogger.Msg($"[{ModName}]: PlayerManager_ProcessPickupItemInteraction.Prefix: forceEquip: {Settings.Get().ForcePickup}");
                MelonLogger.Msg($"[{ModName}]: PlayerManager_ProcessPickupItemInteraction.Prefix: ForceImmediatePickup: {Settings.Get().ForceImmediatePickup}");
                MelonLogger.Msg($"[{ModName}]: PlayerManager_ProcessPickupItemInteraction.Prefix: SkipAudio: {Settings.Get().SkipAudio}");
#endif
                //forceEquip              = Settings.Get().ForcePickup;
                //forceEquipImmediate     = Settings.Get().ForceImmediatePickup;
                //skipAudio               = Settings.Get().SkipAudio;

                //if (Settings.Get().ForcePickup) return true;
                //else return false;
                return false;
            }
            else return true;
        }
    }
}
#pragma warning restore IDE0051 // Remove unused private members