using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class JudgeScreen
{
    [MenuItem("GFramework/7.判断横竖屏(运行状态)")]
    public static void ClickMenu()
    {
        var screen = Screen.width > Screen.height;
        float value = 0;
        if (screen)
        {
            value = (float)Screen.width / Screen.height;
        }
        else
        {
            value = (float)Screen.height / Screen.width;
        }
        Debug.Log(screen ? "横屏" : "竖屏" + "--高宽比:" + value);
    }
}
