using MelonLoader;
using HarmonyLib;
using Il2Cpp;

namespace NoCharcoalPickup
{
    public class Implementation : MelonMod
    {
        public override void OnInitializeMelon()
        {
            NoPickupSettings.OnLoad();
        }
    }
}