using UnityEngine;
using UnityEditor;
using System;

namespace GFramework.EditorTool
{
    public class GenerateUnityPackageNameCopytoShearplate
    {
        [MenuItem("GFramework/2.生成UnityPackage文件名，并复制到剪切板")]
        static void ClickMenu()
        {
            string packageName = "GFramework_" + DateTime.Now.ToString("yyyy.MM.dd.HH.mm.ss");
            GUIUtility.systemCopyBuffer = packageName;
        }
    }
}
