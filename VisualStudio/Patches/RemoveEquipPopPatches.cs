using Il2CppAudio.SimpleAudio;
using Il2CppNodeCanvas.Tasks.Actions;

namespace HUDImprovements.Patches;

internal static class RemoveEquipPopUpPatches
{
    [HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.Update))]
    private static class RemoveFeatUnlockIcon

    {
        private static void Postfix(Panel_HUD __instance)
        {
            if (HUDImprovementsSettings.Instance.AmmoWidgets == true)
            {
                __instance.m_EquipItemPopup.gameObject.SetActive(true);
            }
            else
            {
                __instance.m_EquipItemPopup.gameObject.SetActive(false);
            }
        }
    }
}
