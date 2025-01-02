using HUDImprovements;

[HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.UpdateSafehouse))]
internal class HideSafehouseIcon
{
    internal static void Postfix(ref Panel_HUD __instance)
    {
        if (HUDImprovementsSettings.Instance.HideIcon == true)
        {
            __instance.m_SafehouseRoot.gameObject.SetActive(true);
        }
        else
        {
            __instance.m_SafehouseRoot.gameObject.SetActive(false);
        }
    }
}