using Il2CppRewired.ComponentControls.Data;
using ModSettings;
using MelonLoader;
using UnityEngine;

namespace HUDImprovements
{
    internal class Settings : JsonModSettings
    {
        internal static Settings instance = new Settings();

        [Section("Yes I Know Settings")]

        [Name("General Items")]
        [Description("Enable/disable hovertext on items")]
        public bool hoverGeneral = false;

        [Name("Fire")]
        [Description("Enable/disable hovertext on fire / stoves")]
        public bool hoverFire = false;

        [Section("Essential")]

        [Name("Enable Meter Widgets")]
        [Description("If enabled, displays all meters in the lower right corner: ammunition Count, lantern/torch fuel meter ect...")]
        public bool AmmoWidgets = false;

        [Name("Enable Keybind Widget")]
        [Description("If enabled, displays keybinds on screen when equiping and placing items.")]
        public bool PickUpWidget = false;

        [Name("Enable Sprain Icon")]
        [Description("If enabled, displays sprain risk icon in the lower right corner.")]
        public bool SprainRiskWidget = false;

        [Name("Enable Sprint Stamina Meter")]
        [Description("If enabled, displays sprinting stamina meter.")]
        public bool SprintMeter = false;

        [Name("Enable Aiming Stamina Meter")]
        [Description("If enabled, displays aiming stamina meter.")]
        public bool AimMeter = false;

        [Name("Enable Affliction Event Table")]
        [Description("If enabled, displays affliction table.")]
        public bool AfflictionTable = false;

        [Name("Enable Thin Ice Widget")]
        [Description("If enabled, displays thin ice warning at the top of the screen.")]
        public bool ThinIce = false;

        [Name("Respirator Meter Mode")]
        [Description("Vanilla = shows only when wearing a respirator, Hidden = never shows.")]
        public RespiratorMode RespiratorMeter = RespiratorMode.Vanilla;

        [Name("Suffocating Meter Mode")]
        [Description("Vanilla = shows only when suffocating, Hidden = never shows.")]
        public SuffocatingMode SuffocatingMeter = SuffocatingMode.Vanilla;

        [Section("Non Essential")]

        [Name("Buff Pop-up Icons")]
        [Description("Vanilla = Works like normal, Hidden = never shows.")]
        public BuffPopups buffPopups = BuffPopups.Vanilla;

        [Name("Feat Unlocked Icon")]
        [Description("Vanilla = Works like normal, Hidden = never shows.")]
        public Feats feats = Feats.Vanilla;


        [Name("Enable Travois Carry Icon")]
        [Description("If enabled, displays travois icon in the lower right corner.")]
        public bool TravoisCarry = false;

        [Name("Enable Crouch Icon")]
        [Description("If enabled, displays crouch icon in the lower right corner.")]
        public bool Crouch = false;

        [Name("Safehouse Customization Icon")]
        [Description("Vanilla = Works like normal, Hidden = never shows.")]
        public SafehouseMode SafehouseIcon = SafehouseMode.Vanilla;

        [Name("Enable Sheltered Icon")]
        [Description("If enabled, displays a little sheltered icon at the top of the screen.")]
        public bool Sheltered = false;

        protected override void OnConfirm()
        {
            base.OnConfirm();
            instance.RefreshGUI();
        }
        public enum SuffocatingMode
        {
            Vanilla, // shows only when suffocating
            Hidden   // never shows
        }

        public enum RespiratorMode
        {
            Vanilla, // shows only when suffocating
            Hidden   // never shows
        }

        public enum SafehouseMode
        {
            Vanilla, // shows only when suffocating
            Hidden   // never shows
        }

        public enum BuffPopups
        {
            Vanilla, // shows only when suffocating
            Hidden   // never shows
        }

        public enum Feats
        {
            Vanilla, // shows only when suffocating
            Hidden   // never shows
        }
        protected override void OnChange(FieldInfo field, object? oldValue, object? newValue) => RefreshFields();

        internal static void OnLoad()
        {
            instance.RefreshFields();
        }
        internal void RefreshFields()
        {
            if(instance.AmmoWidgets == true)
            {
                SetFieldVisible(nameof(instance.PickUpWidget), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.PickUpWidget), false);
            }
        }
    }
}