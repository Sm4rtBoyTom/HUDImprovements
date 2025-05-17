namespace HUDImprovements.Patches;
internal static class RemoveStaminaBarPatches
{
    [HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.Update))]
    internal class RemoveSprintBar
    {
        private static void Postfix(Panel_HUD __instance)
        {
            if (HUDImprovementsSettings.Instance.SprintMeter == true)
            {
                __instance.m_SprintBar.gameObject.SetActive(true);
            }
            else
            {
                __instance.m_SprintBar.gameObject.SetActive(false);
            }
        }
    }
    [HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.UpdateAimingStaminaBar))]
    internal static class RemoveAimBarPatches
    {
        private static void Postfix(Panel_HUD __instance)
        {
            if (HUDImprovementsSettings.Instance.AimMeter == true)
            {
                __instance.m_AimingStaminaBar.gameObject.SetActive(true);
            }
            else
            {
                __instance.m_AimingStaminaBar.gameObject.SetActive(false);
            }
        }
    }
}