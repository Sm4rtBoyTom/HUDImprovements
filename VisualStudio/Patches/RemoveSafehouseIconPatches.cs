using HUDImprovements;

namespace HUDImprovements.Patches
{
    [HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.UpdateSafehouse))]
internal static class HideSafehouseIcon
{
    private static bool Prefix(ref Panel_HUD __instance)
    {
        if (Settings.instance.SafehouseIcon == Settings.SafehouseMode.Hidden)
        {
          __instance.m_SafehouseRoot.active = false;
                return false;
        }
        return true;
        }
}
}