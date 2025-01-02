namespace HUDImprovements.Patches
{
    internal static class RemoveRightCornerSpritesPatches
    {
        
        [HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.Update))]
        internal static class RemoveCrouchIcon
        {
            private static void Postfix(Panel_HUD __instance)
            {
                if (HUDImprovementsSettings.Instance.Crouch == true)
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
        internal static class RemoveTravoisIcon
        {
            private static void Postfix(Panel_HUD __instance)
            {
                if (HUDImprovementsSettings.Instance.TravoisCarry == true)
                {
                    __instance.m_Sprite_TravoisCarry.gameObject.SetActive(true);
                }
                else
                {
                    __instance.m_Sprite_TravoisCarry.gameObject.SetActive(false);
                }
            }
        }
        [HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.Update))]
        internal static class RemoveBuffCarry
        {
            private static void Postfix(Panel_HUD __instance)
            {
                if (HUDImprovementsSettings.Instance.BuffPopUpWidgets == true)
                {
                    __instance.m_Sprite_CapacityBuff.gameObject.SetActive(true);
                }
                else
                {
                    __instance.m_Sprite_CapacityBuff.gameObject.SetActive(false);
                }
            }
        }
        [HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.Update))]
        internal static class RemoveEncumbered
        {
            private static void Postfix(Panel_HUD __instance)
            {
                if (HUDImprovementsSettings.Instance.BuffPopUpWidgets == true)
                {
                    __instance.m_Sprite_Encumbered.gameObject.SetActive(true);
                }
                else
                {
                    __instance.m_Sprite_Encumbered.gameObject.SetActive(false);
                }
            }
        }
    }
}
