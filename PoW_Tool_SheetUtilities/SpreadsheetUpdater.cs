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

            string talkPath = textAssetFolder + Path.DirectorySeparatorChar + "Talk.bytes";
            TalkAssetHandler talkAssetHandler = new TalkAssetHandler();
            talkAssetHandler.UpdateSheetFromGameFile(talkPath);
        }
    }
}
