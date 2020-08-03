﻿using System.IO;

using BepInEx;

using HarmonyLib;

namespace EnglishPatch
{
    //Dependency for ModAPI since ModAPI handles resource loading redirection
    [BepInDependency("plugins.modapi", BepInDependency.DependencyFlags.HardDependency)]

    [BepInPlugin("plugins.englishpatch", "English Patch", "1.0.0.0")]
    [BepInProcess("PathOfWuxia.exe")]
    public class EnglishPatch : BaseUnityPlugin
    {
        private Harmony _HM;
        void Awake()
        {

            ModAPI.ModAPI.GetInstance().ResourceRedirector.AddRessourceFolder(@"Mods" + Path.DirectorySeparatorChar + "EnglishTranslate");

            _HM = new Harmony("EnglishPatch");
            _HM.PatchAll();
        }

        void OnDestroy()
        {
            _HM.UnpatchAll("EnglishPatch");
        }
    }
}
