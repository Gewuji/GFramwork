using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.IO;

namespace GFramework.EditorTool
{
    public class CreateUnityPackageAndOpentheFolder
    {
        [MenuItem("GFramework/4.导出unitypackage文件,到Plguin文件夹")]
        static void ClickMenu()
        {
            string assetsPathName = "Assets/GFramework";
            string packageName = "GFramework_" + DateTime.Now.ToString("yyyy.MM.dd.HH.mm.ss") + ".unitypackage";
            string packagePath = Application.dataPath + "/Plugin/unitypackage/";
            if (Directory.Exists(packagePath) == false)
            {
                Directory.CreateDirectory(packagePath);
            }
            AssetDatabase.ExportPackage(assetsPathName, packagePath + packageName, ExportPackageOptions.Recurse);
        }
    }
}
