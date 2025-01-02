using HUDImprovements;

[HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.UpdateRespiratorMeter))]
internal class RespiratorWidgetPatches
{
    internal static void Postfix(ref Panel_HUD __instance)
    {
        if (HUDImprovementsSettings.Instance.Respirator == true)
        {
            __instance.m_RespiratorMeterWidget.gameObject.SetActive(true);
        }
        else
        {
            __instance.m_RespiratorMeterWidget.gameObject.SetActive(false);
        }
    }
}