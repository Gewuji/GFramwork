using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

namespace GFramework.EditorTool
{
    public class OpenSpecialFolder
    {
        [MenuItem("GFramework/打开特殊文件夹/1.打开streamingAssetsPath文件夹")]
        static void ClickMenuStreamAsset()
        {
            if (Directory.Exists(UnityEngine.Application.streamingAssetsPath) == false)
            {
                Directory.CreateDirectory(UnityEngine.Application.streamingAssetsPath);
            }
            Application.OpenURL("file:///" + Application.streamingAssetsPath);
        }

        [MenuItem("GFramework/打开特殊文件夹/2.打开Resources文件夹")]
        static void ClickMenuResources()
        {
            if (Directory.Exists(Application.dataPath + "/Resources") == false)
            {
                Directory.CreateDirectory(Application.dataPath + "/Resources");
            }
            Application.OpenURL("file:///" + Application.dataPath + "/Resources");
        }

        [MenuItem("GFramework/打开特殊文件夹/3.打开Plugin文件夹")]
        static void ClickMenuPlugin()
        {
            if (Directory.Exists(Application.dataPath + "/Plugin") == false)
            {
                Directory.CreateDirectory(Application.dataPath + "/Plugin");
            }
            Application.OpenURL("file:///" + Application.dataPath + "/Plugin");
        }
    }
}
