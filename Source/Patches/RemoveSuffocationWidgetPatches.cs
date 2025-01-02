using HUDImprovements;

[HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.UpdateRespiratorMeter))]
internal class SuffocationWidgetPatches
{
    internal static void Postfix(ref Panel_HUD __instance)
    {
        if (HUDImprovementsSettings.Instance.Suffocation == true)
        {
            __instance.m_SuffocatingMeterWidget.gameObject.SetActive(true);
        }
        else
        {
            __instance.m_SuffocatingMeterWidget.gameObject.SetActive(false);
        }
    }
}