using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

namespace GFramework.EditorTool
{
    public class GenerateUnityPackageName
    {
        [MenuItem("GFramework/1.生成UnityPackage文件名")]
        static void Create()
        {
            string packageName = "GFramwork_" + DateTime.Now.ToString("yyyy.MM.dd.HH.mm.ss");
            MonoBehaviour.print(packageName);
        }
    }
}
