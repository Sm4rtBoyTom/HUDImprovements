namespace HUDImprovements.Patches
{
    internal class AfflictionEventTablePatches
    {

        [HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.Update))]
        internal static class RemoveAfflictionIcon
        {
            private static void Postfix(Panel_HUD __instance)
            {
                if (!Settings.instance.AfflictionTable == true)
                {
                    __instance.m_PlayerDamageEventsGrid.gameObject.SetActive(false);
                    return;     
                }

                __instance.m_PlayerDamageEventsGrid.gameObject.SetActive(__instance.ShouldShowAfflictionSprite());
            }
        }
    }
}