using Il2Cpp;

namespace NoCharcoalPickup
{
    public static class BuildInfo
    {
        #region Must Be Set
        public const string Name                        = "No-Pickup-Charcoal";         // Name of the Mod.
        public const string Author                      = "The Illusion";               // Author of the Mod.
        internal static string Version                  = "0.0.1";

        #endregion
        #region Optional
        public const string? Description                = null;                         // Description for the Mod.  (Set as null if none)
        public const string? Company                    = null;                         // Company that made the Mod.  (Set as null if none)
        public const Version? SupportedGameVersion      = null;                         // Used to set what version the mod supports (Latest) (Set to null if none)
        public const string? DownloadLink               = null;                         // Download Link for the Mod.  (Set as null if none)
        #endregion
        //internal static bool GetIsCompatibleWithGame()
        //{
        //    if (SupportedGameVersion != null)
        //    {
        //        if (SupportedGameVersion >= GameManager.m_GameVersionString)
        //        {

        //        }
        //    }
        //}
    }
}
