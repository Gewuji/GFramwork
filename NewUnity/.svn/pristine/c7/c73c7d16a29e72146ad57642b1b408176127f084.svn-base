using UnityEditor;
using System;

namespace GFramework.EditorTool
{
    public class CreateUnityPackageFile
    {
        [MenuItem("GFramework/3.直接生成UnityPackage文件")]
        static void ClickMenu()
        {
            string assetPath = "Assets/GFramework";
            string packageName = "GFramework" + DateTime.Now.ToString("yyyy.MM.dd.HH.mm.ss") + ".unitypackage";
            AssetDatabase.ExportPackage(assetPath, packageName, ExportPackageOptions.Recurse);
            UnityEngine.MonoBehaviour.print("导出成功:" + packageName);
        }
    }
}
