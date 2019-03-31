using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.IO;

namespace GFramework.EditorTool
{
    public class Summarize
    {
        [MenuItem("GFramework/总结内容/1.生成UnityPackage文件名")]
        public static void ClickMenu0()
        {
            MonoBehaviour.print(ReturnUnityPackageName());
        }

        private static string ReturnUnityPackageName()
        {
            return "GFramwork_" + DateTime.Now.ToString("yyyy.MM.dd.HH.mm.ss");
        }

        [MenuItem("GFramework/总结内容/2.生成UnityPackage文件名，并复制到剪切板")]
        public static void ClickMenu1()
        {
            CopyText(ReturnUnityPackageName());
        }

        private static void CopyText(string content)
        {
            GUIUtility.systemCopyBuffer = content;
        }

        [MenuItem("GFramework/总结内容/3.直接生成UnityPachage文件 %#e")]
        public static void ClickMenu2()
        {
            CreateUnityPackageFile("Assets/GFramework", "Assets/Plugin/unitypackage/", ReturnUnityPackageName());
        }

        private static void CreateUnityPackageFile(string assetsPath, string packagePath, string fileName)
        {
            if (!Directory.Exists(packagePath))
            {
                Directory.CreateDirectory(packagePath);
            }
            AssetDatabase.ExportPackage(assetsPath, packagePath + fileName + ".unitypackage", ExportPackageOptions.Recurse);
        }


    }
}
