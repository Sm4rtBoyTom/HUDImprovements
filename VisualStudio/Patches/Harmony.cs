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
                return HUDImprovementsSettings.options.hoverFire;
            }
            else if (itemUnderCrosshairs.GetComponent<WoodStove>())
            {
                return HUDImprovementsSettings.options.hoverFire;
            }
            else if (itemUnderCrosshairs.GetComponent<Forge>())
            {
                return HUDImprovementsSettings.options.hoverFire;
            }           

            return HUDImprovementsSettings.options.hoverGeneral;
        }
    }
}