namespace HUDImprovements.Patches
{
    internal static class RemoveRightCornerSpritesPatches
    {
        
        [HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.Update))]
        internal static class RemoveCrouchIcon
        {
            private static void Postfix(Panel_HUD __instance)
            {
                if (Settings.instance.Crouch == true)
                {
                    __instance.m_Sprite_Crouching.gameObject.SetActive(true);
                }
                else
                {
                    __instance.m_Sprite_Crouching.gameObject.SetActive(false);
                }
            }
        }
        [HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.Update))]
        internal static class RemoveSprain
        {
            private static void Postfix(Panel_HUD __instance)
            {
                if (Settings.instance.SprainRiskWidget == true)
                {
                    __instance.m_SprainWarningWidget.gameObject.SetActive(true);
                }
                else
                {
                    __instance.m_SprainWarningWidget.gameObject.SetActive(false);
                }
            }
        }
        [HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.Update))]
        internal static class RemoveTravoisIcon
        {
            private static void Postfix(Panel_HUD __instance)
            {
                if (!Settings.instance.TravoisCarry)
                {
                    __instance.m_Sprite_TravoisCarry.gameObject.SetActive(false);
                    return;
                }

                // If enabled in settings, follow the real carry state
                __instance.m_Sprite_TravoisCarry.gameObject.SetActive(__instance.DoingTravoisCarry());
            }
        }
        [HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.Update))]
        internal static class RemoveBuffCarry
        {
            internal static bool Prefix(Panel_HUD __instance)
            {
                if (Settings.instance.buffPopups == Settings.BuffPopups.Hidden)
                {
                    __instance.m_Sprite_CapacityBuff.gameObject.SetActive(false);
                    return false;
                }
                return true;
            }
        }
    }
}
