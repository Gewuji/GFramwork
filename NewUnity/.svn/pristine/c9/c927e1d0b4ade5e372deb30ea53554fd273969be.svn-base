using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace GFramework.EditorTool
{
    public class MenuItemReuse
    {
        [MenuItem("GFramework/5.复用之前按钮打包UnityPackage,并打开目标所在文件夹 %e")]
        private static void ClickMenu()
        {
            EditorApplication.ExecuteMenuItem("GFramework/4.导出unitypackage文件,到Plguin文件夹");
            Application.OpenURL("file:///" + Application.dataPath + "/Plugin/unitypackage");
        }
    }
}
