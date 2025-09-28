using HUDImprovements;

[HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.Update))]
internal class ShelteredIconPatches
{
    internal static void Postfix(ref Panel_HUD __instance)
    {
        if (Settings.instance.Sheltered == true)
        {
            __instance.m_Sprite_Sheltered.gameObject.SetActive(true);
        }
        else
        {
            __instance.m_Sprite_Sheltered.gameObject.SetActive(false);
        }
    }
}