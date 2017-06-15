using UnityEngine;
using UnityEditor;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using YZL.Compress.UPK;
using YZL.Compress.Info;

class PackageData {
    [UnityEditor.MenuItem("Tools/PackageData")]
    public static void PackageAssets()
	{
        UPKFolder.PackFolderAsync(LuaCommon.resultPath + "MyAssets", LuaCommon.resultPath + "MyAssets.upk", ShowProgress);
        AssetDatabase.Refresh();
    }
    static void ShowProgress(long all, long now)
    {
        double progress = (double)now / all;
        Debug.Log("当前进度为: " + progress);
    }
    [UnityEditor.MenuItem("Tools/UnPackageData")]
    public static void UnPackageAssets()
    {
        UPKFolder.UnPackFolderAsync(Application.persistentDataPath + "/MyAssets.upk", Application.persistentDataPath + "/", ShowProgress);
        AssetDatabase.Refresh();
    }
}
