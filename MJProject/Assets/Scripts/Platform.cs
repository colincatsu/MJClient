﻿using UnityEngine;
using System.Collections;
using System;
using System.IO;
using System.Collections.Generic;
using XLua;
using gcloud_voice;

[LuaCallCSharp]
public class Platform : MonoBehaviour {
    private static Platform _instance;
    public static Texture myWXPic;
    public IGCloudVoice m_voiceengine = null;
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
        if (!LuaCommon.isAndroid)
            return;
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
        if (!Directory.Exists(Application.persistentDataPath + "/ImageCache/"))
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/ImageCache/");
        }
        myWXPic = null;
    }

    public void InitGVoice(string appID, string appKey, string openID)
    {
        if (m_voiceengine == null)
        {
            m_voiceengine = GCloudVoice.GetEngine();
            m_voiceengine.SetAppInfo(appID, appKey, openID);
            m_voiceengine.Init();
        }
    }
    [LuaCallCSharp]
    public void SetCallBack(IGCloudVoice.JoinRoomCompleteHandler OnJoinRoomComplete, IGCloudVoice.QuitRoomCompleteHandler OnQuitRoomComplete, IGCloudVoice.MemberVoiceHandler OnMemberVoice)
    {
        if(m_voiceengine != null)
        {
            m_voiceengine.OnJoinRoomComplete += OnJoinRoomComplete;
            m_voiceengine.OnQuitRoomComplete += OnQuitRoomComplete;
            m_voiceengine.OnMemberVoice += OnMemberVoice;
        }
    }

    public void SetAsyncImage(string url)
    {
        //开始下载图片前，将UITexture的主图片设置为占位图  
        if (myWXPic != null)
        {
            return;
        }

        //判断是否是第一次加载这张图片  
        if (!File.Exists(path + url.GetHashCode()))
        {
            //如果之前不存在缓存文件  
            StartCoroutine(DownloadImage(url));
        }
        else
        {
            StartCoroutine(LoadLocalImage(url));
        }
    }

    IEnumerator DownloadImage(string url)
    {
        Debug.Log("downloading new image:" + path + url.GetHashCode());//url转换HD5作为名字  
        WWW www = new WWW(url);
        yield return www;

        Texture2D tex2d = www.texture;
        //将图片保存至缓存路径  
        byte[] pngData = tex2d.EncodeToPNG();                         //将材质压缩成byte流  
        File.WriteAllBytes(path + url.GetHashCode(), pngData);        //然后保存到本地  

        myWXPic = (Texture)tex2d;
    }

    IEnumerator LoadLocalImage(string url)
    {
        string filePath = "file:///" + path + url.GetHashCode();

        Debug.Log("getting local image:" + filePath);
        WWW www = new WWW(filePath);
        yield return www;

        Texture2D texture = www.texture;
        myWXPic = (Texture)texture;
    }

    public string path
    {
        get
        {
            //pc,ios //android :jar:file//  
            return Application.persistentDataPath + "/ImageCache/";

        }
    }

    public void GetWeChatMethod(string methodName)
    {
        if(currentActivity != null)
        {
            currentActivity.Call(methodName);
        }
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
        if (m_voiceengine != null)
        {
            m_voiceengine.Poll();
        }
    }

    public void OnApplicationPause(bool pauseStatus)
    {
        Debug.Log("Voice OnApplicationPause: " + pauseStatus);
        if (pauseStatus)
        {
            if (m_voiceengine == null)
            {
                return;
            }
            m_voiceengine.Pause();
            //s_strLog += "\r\n pause:"+ret;
        }
        else
        {
            if (m_voiceengine == null)
            {
                return;
            }
            m_voiceengine.Resume();
            //s_strLog += "\r\n resume:"+ret;
        }
    }
}