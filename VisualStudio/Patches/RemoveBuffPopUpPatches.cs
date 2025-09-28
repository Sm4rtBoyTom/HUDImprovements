using Il2CppAudio.SimpleAudio;

namespace HUDImprovements.Patches;

internal static class RemoveBuffPopUpPatches
{
    [HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.HideBuffNotification))]
    private static class RemoveBuffIcons

    {
        internal static bool Prefix(Panel_HUD __instance)
        {
          if (Settings.instance.buffPopups == Settings.BuffPopups.Hidden)
            {
               __instance.m_BuffSprite.gameObject.SetActive(false);
                return false;
            }
          return true;
        }
        
    }
    [HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.Update))]
    private static class RemoveBuffLabel
    {
        internal static bool Prefix(Panel_HUD __instance)

        {
            if (Settings.instance.buffPopups == Settings.BuffPopups.Hidden)
            {
                __instance.m_BuffNameLabel.gameObject.SetActive(false);
                return false;
            }
            return true;
        }
    }
    [HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.Update))]

    private static class RemoveBuffNotifications
    {
        internal static bool Prefix(Panel_HUD __instance)
        {
            if (Settings.instance.buffPopups == Settings.BuffPopups.Hidden)
            {
                __instance.m_BuffNotificationParent.gameObject.SetActive(false);
                return false;
            }
            return true;
        }
    }
    private static class RemoveSprintBuffSprite
    {
        internal static bool Prefix(Panel_HUD __instance)
        {
            if (Settings.instance.buffPopups == Settings.BuffPopups.Hidden)
            {
                __instance.m_Sprite_SprintBuffBar.gameObject.SetActive(false);
                return false;
            }
            return true;
        }
    }
    [HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.Update))]
    private static class BuffHeaderLabel
    {
        internal static bool Prefix(Panel_HUD __instance)
        {
            if (Settings.instance.buffPopups == Settings.BuffPopups.Hidden)
            {
                __instance.m_BuffHeaderLabel.gameObject.SetActive(false);
                return false;
            }
            return true;
        }
    }
    [HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.Update))]
    private static class BuffNotificationAimingParent
    {
        internal static bool Prefix(Panel_HUD __instance)
        {
            if (Settings.instance.buffPopups == Settings.BuffPopups.Hidden)
            {
                __instance.m_BuffNotificationAimingParent.gameObject.SetActive(false);
                return false;
            }
            return true;
        }
    }
    [HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.Update))]
    private static class BuffNotificationPanel
    {
        internal static bool Prefix(Panel_HUD __instance)
        {
            if (Settings.instance.buffPopups == Settings.BuffPopups.Hidden)
            {
                __instance.m_BuffNotificationPanel.gameObject.SetActive(false);
                return false;
            }
            return true;
        }
    }
}
