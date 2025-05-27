# BetterMagnets

BetterMagnets is a Deep Rock Galactic: Survivor plugin that improves the artifact magnet experience. With this mod, you can earn magnets at the end of each run without losing experience, and the Company Issued Magnet artifact finally gets a real use.

## Features

- **Only Good Magnets**
  By default, only "good" magnets will spawn. Company-issued magnets (which are considered less desirable) are excluded from spawning giving you a 100% experience magnet instead.
  You can toggle this behavior in the config with the `OnlyGoodMagnets` option.

- **Company Issued Magnet Option**
  Optionally, you can enable the `CompanyIssuedMagnetEnabled` setting to automatically add the company-issued magnet artifact to your inventory at the start of each run.

## Installation

1. Install the latest [BepInEx Bleeding Edge](https://builds.bepinex.dev/projects/bepinex_be).
2. Download and extract [BetterMagnets.zip](https://github.com/caioreix/BetterMagnets/releases) into your game's `BepInEx/plugins` folder (preferably extract to a `BetterMagnets` subfolder).
3. Run the game once to generate the initial config file.

## Configuration

After running the game, a config file will be generated. You can edit the following options:

- `OnlyGoodMagnets` (default: `true`):
  If enabled, only good magnets will spawn (no company-issued magnets).

- `CompanyIssuedMagnetEnabled` (default: `false`):
  If enabled, the company-issued magnet artifact will be added to your inventory at the start of each run.
