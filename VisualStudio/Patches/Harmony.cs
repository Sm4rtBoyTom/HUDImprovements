using MelonLoader;
using UnityEngine;
using Il2Cpp;
using Harmony;
using HUDImprovements;


namespace HUDImprovements
{
    [HarmonyLib.HarmonyPatch(typeof(Panel_HUD), "SetHoverText")]
    public class HoverTextPatch
    {
        public static bool Prefix(ref Panel_HUD __instance, ref string hoverText, ref GameObject itemUnderCrosshairs, ref HoverTextState textState)
        {
            if(itemUnderCrosshairs == null)
            {
                return true;
            }

            if (itemUnderCrosshairs.GetComponent<Campfire>())
            {
                return Settings.instance.hoverFire;
            }
            else if (itemUnderCrosshairs.GetComponent<WoodStove>())
            {
                return Settings.instance.hoverFire;
            }
            else if (itemUnderCrosshairs.GetComponent<Forge>())
            {
                return Settings.instance.hoverFire;
            }           

            return Settings.instance.hoverGeneral;
        }
    }
}