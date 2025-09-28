using MelonLoader;
using UnityEngine;
using Il2Cpp;

namespace HUDImprovements.Patches;
internal static class RemoveAmmoIconPatches
{
    [HarmonyPatch(typeof(EquipItemPopup), nameof(EquipItemPopup.Update))]
    private static class RemoveAmmoIcon
    {
        private static void Postfix(EquipItemPopup __instance)
        {
          if (Settings.instance.AmmoWidgets == true)
            {
              __instance.m_AmmoWidget.gameObject.SetActive(true);
                Settings.instance.PickUpWidget = true; 
            }
          else 
            {
                __instance.m_AmmoWidget.gameObject.SetActive(false);
            }
        }
        
    }
}