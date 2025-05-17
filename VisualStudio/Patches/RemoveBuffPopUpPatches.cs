namespace HUDImprovements.Patches;

internal static class RemoveBuffPopUpPatches
{
    [HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.Update))]
    private static class RemoveBuffIcons

    {
        private static void Postfix(Panel_HUD __instance)
        {
          if (HUDImprovementsSettings.Instance.BuffPopUpWidgets==true)
            {
             __instance.m_BuffSprite.gameObject.SetActive(true);
            }
          else
            {
             __instance.m_BuffSprite.gameObject.SetActive(false);
            }
        }
        
    }
    [HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.Update))]
    private static class RemoveBuffLabel
    {
        private static void Postfix(Panel_HUD __instance)

        {
            if (HUDImprovementsSettings.Instance.BuffPopUpWidgets == true)
            {
                __instance.m_BuffNameLabel.gameObject.SetActive(true);
            }
            else
            {
                __instance.m_BuffNameLabel.gameObject.SetActive(false);
            }
        }
    }
    [HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.Update))]

    private static class RemoveBuffNotifications
    {
        private static void Postfix(Panel_HUD __instance)
        {
            if (HUDImprovementsSettings.Instance.BuffPopUpWidgets == true)
            {
                __instance.m_BuffNotificationParent.gameObject.SetActive(true);
            }
            else
            {
                __instance.m_BuffNotificationParent.gameObject.SetActive(false);
            }
        }
    }
    private static class RemoveSprintBuffSprite
    {
        private static void Postfix(Panel_HUD __instance)
        {
            if (HUDImprovementsSettings.Instance.BuffPopUpWidgets == true)
            {
                __instance.m_Sprite_SprintBuffBar.gameObject.SetActive(true);
            }
            else
            {
                __instance.m_Sprite_SprintBuffBar.gameObject.SetActive(false);
            }
        }
    }
    [HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.Update))]
    private static class BuffHeaderLabel
    {
        private static void Postfix(Panel_HUD __instance)
        {
            if (HUDImprovementsSettings.Instance.BuffPopUpWidgets == true)
            {
                __instance.m_BuffHeaderLabel.gameObject.SetActive(true);
            }
            else
            {
                __instance.m_BuffHeaderLabel.gameObject.SetActive(false);
            }
        }
    }
    [HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.Update))]
    private static class BuffNotificationAimingParent
    {
        private static void Postfix(Panel_HUD __instance)
        {
            if (HUDImprovementsSettings.Instance.BuffPopUpWidgets == true)
            {
                __instance.m_BuffNotificationAimingParent.gameObject.SetActive(true);
            }
            else
            {
                __instance.m_BuffNotificationAimingParent.gameObject.SetActive(false);
            }
        }
    }
    [HarmonyPatch(typeof(Panel_HUD), nameof(Panel_HUD.Update))]
    private static class BuffNotificationPanel
    {
        private static void Postfix(Panel_HUD __instance)
        {
            if (HUDImprovementsSettings.Instance.BuffPopUpWidgets == true)
            {
                __instance.m_BuffNotificationPanel.gameObject.SetActive(true);
            }
            else
            {
                __instance.m_BuffNotificationPanel.gameObject.SetActive(false);
            }
        }
    }
}
