using XLua;
using UnityEngine;

using System.Collections.Generic;
using System;
public class LuaEnvSingleton  {
	
	static private LuaEnv _instance = null;
	static public LuaEnv Instance
	{
		get
		{
			if(_instance == null)
			{
				_instance = new LuaEnv();
			}
			
			return _instance;
		}
	}
}

[LuaCallCSharp]
public class LuaCommon
{
#if     UNITY_IOS || UNITY_IPHONE
    public static string resultPath = Application.persistentDataPath + "/";
	public static string xxxtdrfilepath = Application.dataPath + "/Raw" + "/testxxx.tdr";
	public static string xxxtdr2filepath = Application.dataPath + "/Raw" + "/testxxx2.tdr";
	public static bool android_platform = false;
#elif   UNITY_ANDROID
    public static string resultPath = "/sdcard/luatest/";
	public static string xxxtdrfilepath = Application.streamingAssetsPath + "/testxxx.tdr";
	public static string xxxtdr2filepath = Application.streamingAssetsPath + "/testxxx2.tdr";
	public static bool android_platform = true;
#elif   UNITY_EDITOR
    public static string resultPath = Application.dataPath + "/StreamingAssets/";
    //public static string xxxtdrfilepath = Application.dataPath + "/StreamingAssets" + "/testxxx.tdr";
    //public static string xxxtdr2filepath = Application.dataPath + "/StreamingAssets" + "/testxxx2.tdr";
    //public static bool android_platform = false;
#else
    public static string resultPath = Application.dataPath + "/StreamingAssets/";
#endif

    public static bool IsMacPlatform()
	{
#if UNITY_EDITOR
        string os = System.Environment.OSVersion.ToString();
        if (os.Contains("Unix"))
        {
            return true;
        }
        else
        {
            return false;
        }
#else
        return false;
#endif
	}

	public static bool IsIOSPlatform()
	{
#if UNITY_IOS || UNITY_IPHONE
		return true;
#else
		return false;
#endif
	}
}

//注意：用户自己代码不建议在这里配置，建议通过标签来声明!!
public class TestCaseGenConfig : XLua.GenConfig
{

    //lua中要使用到C#库的配置，比如C#标准库，或者Unity API，第三方库等。
    public List<Type> LuaCallCSharp
    {
        get
        {
            return new List<Type>()
            {
                typeof(UnityEngine.TextAsset),
//                typeof(EventContext),
//                typeof(EventDispatcher),
//                typeof(EventListener),
//                typeof(InputEvent),
//_GT(typeof(DisplayObject)),
//_GT(typeof(Container)),
//_GT(typeof(Stage)),
//_GT(typeof(Controller)),
//_GT(typeof(GObject)),
//_GT(typeof(GGraph)),
//_GT(typeof(GGroup)),
//_GT(typeof(GImage)),
//_GT(typeof(GLoader)),
//_GT(typeof(PlayState)),
//_GT(typeof(GMovieClip)),
//_GT(typeof(TextFormat)),
//_GT(typeof(GTextField)),
//_GT(typeof(GRichTextField)),
//_GT(typeof(GTextInput)),
//_GT(typeof(GComponent)),
//_GT(typeof(GList)),
//_GT(typeof(GRoot)),
//_GT(typeof(GLabel)),
//_GT(typeof(GButton)),
//_GT(typeof(GComboBox)),
//_GT(typeof(GProgressBar)),
//_GT(typeof(GSlider)),
//_GT(typeof(PopupMenu)),
//_GT(typeof(ScrollPane)),
//_GT(typeof(Transition)),
//_GT(typeof(UIPackage)),
//_GT(typeof(Window)),
//_GT(typeof(GObjectPool)),
//_GT(typeof(Relations)),
//_GT(typeof(RelationType)),
            };
        }
    }

    //C#静态调用Lua的配置（包括事件的原型），仅可以配delegate，interface
    public List<Type> CSharpCallLua {
        get
        {
            return null;
        }
    }

    //黑名单
    public List<List<string>> BlackList
    {
        get
        {
            return null;
        }
    }
}

