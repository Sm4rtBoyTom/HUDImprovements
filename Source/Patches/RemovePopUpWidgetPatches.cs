namespace HUDImprovements.Patches;

internal static class RemovePopUpWidgetPatches
{
    [HarmonyPatch(typeof(EquipItemPopup), nameof(EquipItemPopup.Update))]
    private static class RemovePopUpWidget

    {
        private static void Postfix(EquipItemPopup __instance)
        {
            if (HUDImprovementsSettings.Instance.PickUpWidget == true)
            {
                __instance.m_EquipPopupWidget.gameObject.SetActive(true);
            }
            else
            {
                __instance.m_EquipPopupWidget.gameObject.SetActive(false);
            }
        }
    }
    [HarmonyPatch(typeof(EquipItemPopup), nameof(EquipItemPopup.Update))]
    private static class RemoveReloadButton
    {
        private static void Postfix(EquipItemPopup __instance)
        {
            if (HUDImprovementsSettings.Instance.PickUpWidget == true)
            {
                __instance.m_ButtonPromptReload.gameObject.SetActive(true);
            }
            else
            {
                __instance.m_ButtonPromptReload.gameObject.SetActive(false);
            }
        }
    }
    [HarmonyPatch(typeof(EquipItemPopup), nameof(EquipItemPopup.Update))]
    private static class RemoveLeftIcon
    {
        private static void Postfix(EquipItemPopup __instance)
        {
            if (HUDImprovementsSettings.Instance.PickUpWidget == true)
            {
                __instance.m_ButtonPromptLeft.gameObject.SetActive(true);
            }
            else
            {
                __instance.m_ButtonPromptLeft.gameObject.SetActive(false);
            }
        }
    }
}