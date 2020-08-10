# Path Of Wuxia ModLoader
BepInEx is the actual ModLoader.
This repository contains a ModAPI plugin containing base functionalities for Mods (WIP).
It currently allows dynamic registration of external Asset folders, which allows several mods to register asset overrides.

Additionally this repository contains a EnglishPatch Plugin which registers Mods/EnglishTranslate as a resource folder (So place the translated Asset files into Mods/EnglishTranslate).

and fixes several issues with displaying the English Text.

The Output folder contains an almost full release after building.

The only thing that is missing is the Mods/EnglishTranslate folder.


It includes an already configured BepInEx.

If BepInEx is updated/replaced by a new verion it is important to update the BepInEx.cfg and replace the following Entry.

It is also important that that the winhttp.dll from UnityDoorstop is from this fork https://github.com/Magxm/UnityDoorstop as it allows loading a native dll, which we need for the resource redirection.
Remember this for if you ever replace the BepInEx or UnityDoorstep version (Which should never be needed to begin with).

```ini
[Preloader.Entrypoint]

## The local filename of the assembly to target.
# Setting type: String
# Default value: UnityEngine.CoreModule.dll
Assembly = UnityEngine.CoreModule.dll

## The name of the type in the entrypoint assembly to search for the entrypoint method.
# Setting type: String
# Default value: Application
Type = Object

## The name of the method in the specified entrypoint assembly and type to hook and load Chainloader from.
# Setting type: String
# Default value: .cctor
Method = .cctor
```

otherwise the Entrypoint will be too late and the language files are already loaded.

