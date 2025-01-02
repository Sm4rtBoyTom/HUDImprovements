using MelonLoader;
using UnityEngine;
using UnityEngine.UI;
using Il2CppInterop;
using Il2CppInterop.Runtime.Injection;
using System.Collections;
using ModSettings;

namespace HUDImprovements
{
    /// <inheritdoc/>
	public class Main : MelonMod
    {
        internal static HUDImprovementsSettings settings = new HUDImprovementsSettings();
        /// <inheritdoc/>
        public override void OnInitializeMelon()
        {
         MelonLoader.MelonLogger.Msg(System.ConsoleColor.Green, "Hi, HUD Improvements is on!");
            settings.AddToModSettings("HUD Improvements");

        }

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {

        }
        public override void OnUpdate()
        {

        }

    }
}
