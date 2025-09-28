using HUDImprovements;

[HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.UpdateRespiratorMeter))]
internal class RespiratorWidgetPatches
{
    private static bool Prefix(ref Panel_HUD __instance)
    {
        if (Settings.instance.RespiratorMeter == Settings.RespiratorMode.Hidden)
        {
            __instance.m_RespiratorMeterWidget.gameObject.SetActive(false);
            return false;
        }
        return true;
    }
}
[HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.UpdateRespiratorMeter))]
internal class FeatUnlockedWidgetPatches
{
    private static bool Prefix(ref Panel_HUD __instance)
    {
        if (Settings.instance.feats == Settings.Feats.Hidden)
        {
            __instance.m_FeatUnlockedWidget.gameObject.SetActive(false);
            return false;
        }
        return true;
    }
}