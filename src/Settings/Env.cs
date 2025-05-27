using Utils.Settings;

namespace BetterMagnets.Settings;

public static class ENV {
    private readonly static string general = "⚙️ General";
    public readonly static ConfigElement<bool> OnlyGoodMagnets = Utils.Settings.Config.Bind(
        general,
        nameof(OnlyGoodMagnets),
        true,
        "Only spawn good magnets (no company issued magnet magnets)."
    );

    public readonly static ConfigElement<bool> CompanyIssuedMagnetEnabled = Utils.Settings.Config.Bind(
        general,
        nameof(CompanyIssuedMagnetEnabled),
        false,
        "If enabled, the company issued magnet artifact will be added to the player's inventory."
    );

    public static class General {
        public static void Setup() {
            Utils.Settings.Config.AddConfigActions(Load);
        }

        // Load the plugin config variables.
        private static void Load() {
            Utils.Settings.Config.Save();
        }
    }
}
