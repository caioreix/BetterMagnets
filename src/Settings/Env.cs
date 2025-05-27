using Utils.Settings;

namespace BetterMagnets.Settings;

public static class ENV {
    private readonly static string settings = "0.⚙️ Settings";
    public static ConfigElement<float> Example;

    public static class Settings {
        public static void Setup() {
            Utils.Settings.Config.AddConfigActions(Load);
        }

        // Load the plugin config variables.
        private static void Load() {
            Example = Utils.Settings.Config.Bind(
                settings,
                nameof(Example),
                2F,
                "Just an example value :)"
            );

            Utils.Settings.Config.Save();
        }
    }
}
