﻿using System;
using System.IO;

using PoW_Tool_SheetUtilities.Handler.TextAssets;

namespace PoW_Tool_SheetUtilities
{
    class SpreadsheetUpdater
    {
        public static void UpdateSpreadsheetsFromGameFiles()
        {
            //Get input folder path
            string workingDirectory = Environment.CurrentDirectory;
            string inputFolder = workingDirectory + Path.DirectorySeparatorChar + "Input";

            //Parsing TextAssets
            string textAssetFolder = inputFolder + Path.DirectorySeparatorChar + "chs" + Path.DirectorySeparatorChar + "textfiles";
            //new TalkAssetHandler().UpdateSheetFromGameFile(textAssetFolder);
            new AchievementAssetHandler().UpdateSheetFromGameFile(textAssetFolder);
        }

        public static void ExportToMod()
        {
            //Get input folder path
            string workingDirectory = Environment.CurrentDirectory;
            string outputFolder = workingDirectory + Path.DirectorySeparatorChar + "Output";

            string textAssetFolder = outputFolder + Path.DirectorySeparatorChar + "chs" + Path.DirectorySeparatorChar + "textfiles";

            string talkPath = textAssetFolder + Path.DirectorySeparatorChar + "Talk.txt";
            new TalkAssetHandler().BuildGameDataFromSheet(talkPath);
        }
    }
}
