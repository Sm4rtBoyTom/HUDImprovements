using MelonLoader;
using UnityEngine;
using UnityEngine.UI;
using Il2CppInterop;
using Il2CppInterop.Runtime.Injection;
using System.Collections;
using ModSettings;


namespace HUDImprovements
{
	public class HUDImprovements : MelonMod
    {
        public override void OnInitializeMelon()
        {
            MelonLoader.MelonLogger.Msg(System.ConsoleColor.Green, "Hi, HUD Tweaks is on!");
            Settings.instance.AddToModSettings("HUD Tweaks");
        }
    }
}
