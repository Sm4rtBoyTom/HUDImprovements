using HarmonyLib;
using HUDImprovements;
using UnityEngine;

[HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.UpdateSuffocatingMeter))]
internal static class ToggleSuffocatingMeter
{
    private static bool Prefix(Panel_HUD __instance)
    {
        if (Settings.instance.SuffocatingMeter == Settings.SuffocatingMode.Hidden)
        {
            __instance.m_SuffocatingMeterWidget.gameObject.SetActive(false);
            return false; 
        }
        return true;
    }
}