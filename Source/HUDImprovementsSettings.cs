using Il2CppRewired.ComponentControls.Data;
using ModSettings;

namespace HUDImprovements
{
    internal class HUDImprovementsSettings : JsonModSettings
    {
        internal static HUDImprovementsSettings instance = new HUDImprovementsSettings();
        internal static HUDImprovementsSettings Instance { get; } = new();

        public enum HotkeyPreset { Vanilla, Custom }

        [Section("Essential")]

        [Name("Enable Meter Widgets")]
        [Description("If enabled, displays all meters in the lower right corner for example ammunition Count, lantern/torch fuel meter ect...")]
        public bool AmmoWidgets = false;

        [Name("Enable Sprain Icon")]
        [Description("If enabled, displays sprain risk icon in the lower right corner.")]
        public bool SprainRiskWidget = false;

        [Name("Enable Sprint Meter")]
        [Description("If enabled, displays sprinting stamina meter.")]
        public bool SprintMeter = false;

        [Name("Enable Aiming Stamina Meter")]
        [Description("If enabled, displays aiming stamina meter.")]
        public bool AimMeter = false;

        [Name("Enable Affliction Event Table")]
        [Description("If enabled, displays affliction table.")]
        public bool AfflictionTable = false;

        [Section("Non Essential")]

        [Name("Enable Buff Pop-Ups")]
        [Description("If enabled, displays all buff afflictions pop-ups.")]
        public bool BuffPopUpWidgets = false;

        [Name("Enable Feat Unlock")]
        [Description("If enabled, displays unlock animation when a feat is unlocked. (Primarily intended as a fix to the annoying pop-up every time the game starts.)")]
        public bool FeatUnlockWidget = false;

        [Name("Enable Equip Widget")]
        [Description("If enabled, displays keybinds on screen when equiping and placing items.")]
        public bool PickUpWidget = false;

        [Name("Enable Scent Meter")]
        [Description("If enabled, displays scent meter at the top of the screen.")]
        public bool ScentMeter = false;

        [Name("Enable Travois Carry")]
        [Description("If enabled, displays travois icon in the lower right corner.")]
        public bool TravoisCarry = false;

        [Name("Enable Crouch")]
        [Description("If enabled, displays crouch icon in the lower right corner.")]
        public bool Crouch = false;

        public static HUDImprovementsSettings options;
        internal static void OnLoad()
        {
            options = new HUDImprovementsSettings();
            options.AddToModSettings("HUD Improvements");
            options.RefreshGUI();
        }
        protected override void OnChange(FieldInfo field, object? oldValue, object? newValue)
        {
            base.OnChange(field, oldValue, newValue);
            if (AmmoWidgets == true)
            {
                Instance.AmmoWidgets = true;
            }
            else if (AmmoWidgets == false)
            {
                Instance.AmmoWidgets = false;
            }
            if (BuffPopUpWidgets == true)
            {
                Instance.BuffPopUpWidgets = true;
            }
            else if (BuffPopUpWidgets == false)
            {
                Instance.BuffPopUpWidgets = false;
            }
            if (FeatUnlockWidget == true)
            {
                Instance.FeatUnlockWidget = true;
            }
            else if (FeatUnlockWidget == false)
            { 
                Instance.FeatUnlockWidget = false;
            }
            if (PickUpWidget == true)
            {
                Instance.PickUpWidget = true;
            }
            else if (PickUpWidget == false)
            {
                Instance.PickUpWidget = false;
            }
            if (SprainRiskWidget == true)
            {
                Instance.SprainRiskWidget = true;
            }
            else if(SprainRiskWidget == false)
            {
                Instance.SprainRiskWidget = false;
            }
            if (SprintMeter ==true)
            {
                Instance.SprintMeter = true;
            }
            else if (SprintMeter==false)
            {
                Instance.SprintMeter = false;
            }
            if (AimMeter ==true)
            {
                Instance.AimMeter = true;
            }
            else if (AimMeter==false)
            {
                Instance.AimMeter = false;
            }
            if (ScentMeter == true)
            {
                Instance.ScentMeter = true;
            }
            else if (ScentMeter == false)
                 {
                Instance.ScentMeter = false;
            }
            if (TravoisCarry ==true)
            {
                Instance.TravoisCarry = true;
            }
            else if (TravoisCarry ==false)
            {
                Instance.TravoisCarry = false;
            }
            if (Crouch ==true)
            {
                Instance.Crouch = true;
            }
            else if (Crouch == false)
            {
                Instance.Crouch = false;
            }
            if (AfflictionTable ==true)
            {
                Instance.AfflictionTable = true;
            }
            else if (AfflictionTable ==false)
            {
                Instance.AfflictionTable = false;
            }
        }
    }
}



