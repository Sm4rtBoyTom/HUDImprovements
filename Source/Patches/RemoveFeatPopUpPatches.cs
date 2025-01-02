using Il2CppAudio.SimpleAudio;
using Il2CppNodeCanvas.Tasks.Actions;

namespace HUDImprovements.Patches;

internal static class RemoveFeatPopUpPatches
{
    [HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.Update))]
    private static class RemoveFeatUnlockIcon

    {
        private static void Postfix(Panel_HUD __instance)
        {
            if (HUDImprovementsSettings.Instance.FeatUnlockWidget == true)
            {
                __instance.m_FeatUnlockedBadgeIcon.gameObject.SetActive(true);
            }
            else
            {
                __instance.m_FeatUnlockedBadgeIcon.gameObject.SetActive(false);
            }
        }
    }
    [HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.Update))]
    private static class RemoveFeatFooter
    {
        private static void Postfix(Panel_HUD __instance)
        {
            if (HUDImprovementsSettings.Instance.FeatUnlockWidget == true)
            {
                __instance.m_FeatUnlockedFooter.gameObject.SetActive(true);
            }
            else
            {
                __instance.m_FeatUnlockedFooter.gameObject.SetActive(false);
            }
        }
    }
    [HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.Update))]
    private static class RemoveFeatWidget
    {
        private static void Postfix(Panel_HUD __instance)
        {
            if (HUDImprovementsSettings.Instance.FeatUnlockWidget == true)
            {
                __instance.m_FeatUnlockedWidget.gameObject.SetActive(true);
            }
            else
            {
                __instance.m_FeatUnlockedWidget.gameObject.SetActive(false);
            }
        }
    }
}
