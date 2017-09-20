using UnityEngine;
using System.Collections;
using System.IO;
using XLua;
using YZL.Compress.UPK;
using YZL.Compress.Info;

[LuaCallCSharp]
public class AssetsHandle : MonoBehaviour {
    public static double progress = 0;
    [CSharpCallLua]
    public delegate void OnFinish(double progress);
    public static OnFinish dataFinish;
    public static void UnPackAssetFolder(string inpath ,string outpath)
    {
        UPKFolder.UnPackFolderAsync(inpath, outpath, ShowProgress);
    }
    public static void ShowProgress(long all, long now)
    {
        progress = (double)now / all;
        Debug.Log("当前进度为: " + progress);
        if(dataFinish != null)
        {
            dataFinish(progress);
        }
    }
    public static void CreateNewAsset(byte[] stream,string path)
    {
        Debug.LogWarning("hhhhh");
        FileStream fs = new FileStream(path, FileMode.Create);   //
        fs.Write(stream, 0, stream.Length);
        fs.Flush();
        fs.Close();
        fs.Dispose();
    }
}
