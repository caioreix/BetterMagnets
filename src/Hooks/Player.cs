

using BetterMagnets.Data;
using HarmonyLib;
using UnityEngine.Playables;
using Utils.Logger;

namespace BetterMagnets.Hooks;

[Harmony]

public class PlayerPatch {
    [HarmonyPatch(typeof(Player), nameof(Player.OnExitDropPod))]
    public static class OnExitDropPod {
        public static void Prefix(Player __instance) {
            Log.Info($"player Exited DropPod");
            if (!Settings.ENV.CompanyIssuedMagnetEnabled.ValueFromConfig()) {
                return;
            }

            if (!Artifacts.DataList.TryGetValue(Artifacts.CompanyIssuedMagnetArtifactData, out var artifactData)) {
                Log.Error($"CompanyIssuedMagnetArtifactData not found in Artifacts.DataList");
                return; // Artifact data not found
            }

            foreach (var artifact in __instance.EquippedArtifacts) {
                if (artifact.Data.Id == Artifacts.CompanyIssuedMagnetArtifactData) {
                    Log.Trace($"CompanyIssuedMagnetArtifactData already equipped on player: {__instance.name}");
                    return; // Already equipped, no need to equip again
                }
            }

            __instance.EquipArtifact(artifactData, true);
        }
    }
}
