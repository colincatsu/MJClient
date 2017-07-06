using UnityEngine;
using System.Collections;
using System;
using System.IO;
using System.Collections.Generic;
using XLua;

[LuaCallCSharp]
public class Platform : MonoBehaviour {
    private static Platform _instance;

    public static Platform Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType(typeof(Platform)) as Platform;
                if (_instance == null)
                {
                    _instance = new GameObject("Platform").AddComponent<Platform>();
                    _instance.Awake();
                    DontDestroyOnLoad(_instance.gameObject);
                }
            }
            return _instance;
        }
    }

    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);

        }
        else if (_instance != this)
        {
            Debug.LogWarning("There is already an instance created (" + _instance.name + "). Destroying new one.");
            Destroy(this.gameObject);
            return;
        }
        Init();

    }

    public static AndroidJavaClass jc;
    public static AndroidJavaObject currentActivity;

    void Init()
    {
        Debug.Log("**************Platform Unity Init:" + Debug.isDebugBuild);
        if (Debug.isDebugBuild)
        {
            currentActivity = null;
            return;
        }
        if (currentActivity == null)
        {
            jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            currentActivity = jc.GetStatic<AndroidJavaObject>("currentActivity");
        }
        Debug.Log("**************Platform Unity InitX:" + currentActivity);
    }

    public void LoginWeChat()
    {
        if (currentActivity != null)
            currentActivity.Call("wxLogin");
    }

    [CSharpCallLua]
    public delegate int LDelegate(string nickname, string sex, string headimgurl);
    public LDelegate func = null;

    public void LoginUserMsg()
    {
        string nickname = "";
        string sex = "";
        string headimgurl = "";
        if (currentActivity != null)
        {
            nickname = currentActivity.Call<string>("getNickName");
            sex = currentActivity.Call<string>("getUserSex");
            headimgurl = currentActivity.Call<string>("getImageUrl");
        }
        if (func != null)
        {
            func(nickname, sex, headimgurl);
        }
    }

    public string GetData(string methodName)
    {
        if (currentActivity != null)
            return currentActivity.Call<string>(methodName);
        return "";
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
