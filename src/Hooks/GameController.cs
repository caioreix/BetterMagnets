using BetterMagnets.Data;

using HarmonyLib;

namespace BetterMagnets.Hooks;

[Harmony]

public class GameControllerPatch {
    private static void Initialize(GameController __instance) {
        if (Controllers.GameController == null) {
            Controllers.GameController = __instance;
        }

        if (Artifacts.DataList.IsEmpty) {
            var artifacts = Controllers.GameController.skillCollectionManager.artifactDataCollection.Data;
            foreach (var artifact in artifacts) {
                Artifacts.DataList.TryAdd(artifact.Id, artifact);
            }
        }
    }

    [HarmonyPatch(typeof(GameController), nameof(GameController.Start))]
    public class Start {
        public static void Postfix(GameController __instance) {
            Initialize(__instance);
        }
    }

    [HarmonyPatch(typeof(GameController), nameof(GameController.Update))]
    public class Update {
        public static void Postfix(GameController __instance) {
            Initialize(__instance);
        }
    }
}
