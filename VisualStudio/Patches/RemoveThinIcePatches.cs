using HUDImprovements;

[HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.Update))]
internal class ThinIcePatches
{
    internal static void Postfix(ref Panel_HUD __instance)
    {
        if (HUDImprovementsSettings.Instance.ThinIce == true)
        {
            __instance.m_ThinIceWidget.gameObject.SetActive(true);
        }
        else
        {
            __instance.m_ThinIceWidget.gameObject.SetActive(false);
        }
    }
}