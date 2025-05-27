
using HarmonyLib;
using UnityEngine;
using Utils.Logger;

namespace BetterMagnets.Hooks;

[Harmony]

public class PickupSpawnerPatch {
    [HarmonyPatch(typeof(PickupSpawner), nameof(PickupSpawner.SpawnArtifactMagnet))]
    public class SpawnArtifactMagnet {
        public static bool Prefix(PickupSpawner __instance, Vector3 position, float pickThreshold) {
            Log.Trace($"SpawnArtifactMagnet called with position: {position}, threshold: {pickThreshold}");

            if (!Settings.ENV.OnlyGoodMagnets.ValueFromConfig()) {
                return true; // Allow the original method to execute if the setting is false
            }

            // instead of spawning a magnet, we can just change the pickupThreshold to 1, im just spawning a normal magnet for visual effect.

            position -= new Vector3(2, 0, 7);
            __instance.SpawnMagnet(position);
            Log.Trace($"SpawnArtifactMagnet ignored and spawned normal magnet at position: {position}");

            return false; // Prevent the original method from executing
        }
    }
}
