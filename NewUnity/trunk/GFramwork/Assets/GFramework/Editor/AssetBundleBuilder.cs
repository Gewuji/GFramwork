using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class AssetBundleBuilder
{
    static string assetsDir = Application.dataPath + "/Resources";

    [MenuItem("GFramework/.自动打包AssetBundle，并生成MD5")]
    static void AutoBuildAll()
    {
        Debug.Log(assetsDir);
    }
}
