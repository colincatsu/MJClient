﻿using UnityEngine;
using System.Collections;
using System;
using System.IO;
using System.Collections.Generic;
using XLua;
using gcloud_voice;
using FairyGUI;

[LuaCallCSharp]
public class Platform : MonoBehaviour {
    private static Platform _instance;
    private Texture[] myWXPic;
    private Dictionary<int, int> code2PicID;
    private static int spriteCnt;
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
        if (!Directory.Exists(Application.persistentDataPath + "/ImageCache/"))
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/ImageCache/");
        }
        myWXPic = new Texture[55];
        spriteCnt = 0;
        code2PicID = new Dictionary<int, int>();
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

    public Texture SetAsyncImage(string url)
    {
        //开始下载图片前，将UITexture的主图片设置为占位图  
        if(url == null || url == "")
        {
            return null;
        }
        int code = url.GetHashCode();  
        if(code2PicID.ContainsKey(code))  
        {
           return myWXPic[code2PicID[code]];
        }  
        else       //如果之前不存在缓存中  就用WWW类下载  
        {
            if (spriteCnt >= 100)
            {
                spriteCnt = 0;
                myWXPic = null;
                code2PicID.Clear();
            }
            StartCoroutine(DownloadImage(url, code));
        }
        return null;
    }
    [CSharpCallLua]
    public delegate void paraDelegate(String para);
    public paraDelegate onWeChatCallBack;
    public void OnWeChatLogin(string userCode)
    {
        if(onWeChatCallBack != null)
        {
            onWeChatCallBack(userCode);
        }
    }

    IEnumerator DownloadImage(string url, int code)
    {
        Debug.Log("downloading new image:" + path + url.GetHashCode());//url转换HD5作为名字  
        WWW www = new WWW(url);
        yield return www;

        Texture2D tex2d = www.texture;
        //将图片保存至缓存路径  
        //byte[] pngData = tex2d.EncodeToPNG();                         //将材质压缩成byte流  
        //File.WriteAllBytes(path + url.GetHashCode(), pngData);        //然后保存到本地  
        //myWXPic = (Texture)tex2d;
        code2PicID[code] = spriteCnt;
        myWXPic[spriteCnt] = (Texture)tex2d;
        if(func != null)
        {
            func();
        }
        ++spriteCnt;
    }

    IEnumerator LoadLocalImage(string url)
    {
        string filePath = "file:///" + path + url.GetHashCode();

        Debug.Log("getting local image:" + filePath);
        WWW www = new WWW(filePath);
        yield return www;

        Texture2D texture = www.texture;
        //myWXPic = (Texture)texture;
    }
    [CSharpCallLua]
    public delegate void SDelegate(float latitude,float longitude);
    public SDelegate gpsGet;

    public void GetGps()
    {
        StartCoroutine(StartGPS());
    }

    IEnumerator StartGPS()
    {
        // Input.location 用于访问设备的位置属性（手持设备）, 静态的LocationService位置  
        // LocationService.isEnabledByUser 用户设置里的定位服务是否启用
        float latitudeInfo = 0f;
        float longitudeInfo = 0f;
        if (!Input.location.isEnabledByUser)
        {
            Debug.LogWarning("isEnabledByUser value is:" + Input.location.isEnabledByUser.ToString() + " Please turn on the GPS");
            yield return false;
        }

        // LocationService.Start() 启动位置服务的更新,最后一个位置坐标会被使用  
        Input.location.Start();

        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            // 暂停协同程序的执行(1秒)  
            yield return new WaitForSeconds(1);
            maxWait--;
        }

        if (maxWait < 1)
        {
            Debug.LogWarning("Init GPS service time out");
            yield return false;
        }

        if (Input.location.status == LocationServiceStatus.Failed)
        {
            Debug.LogWarning("Unable to determine device location");
            //yield return false;
        }
        else
        {
            latitudeInfo = Input.location.lastData.latitude;
            longitudeInfo = Input.location.lastData.longitude;
            //" Time:" + Input.location.lastData.timestamp;
            //yield return new WaitForSeconds(100);
        }
        if(gpsGet != null)
        {
            gpsGet(latitudeInfo, longitudeInfo);
        }
        Input.location.Stop();
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

    public void WXShare(string title,string description)
    {
        if(currentActivity != null)
        {
            currentActivity.Call("wxShare",title,description);
        }
    }

    public void CopyRoomID(string roomid)
    {
        if (currentActivity != null)
        {
            currentActivity.Call("wxCopyRoom", roomid);
        }
    }

    [CSharpCallLua]
    public delegate void LDelegate();
    public LDelegate func = null;

    public void SetFuncDelegate(LDelegate callBack)
    {
        func += callBack;
    }

    public void LoginUserMsg()
    {
        //string nickname = "";
        //string sex = "";
        //string headimgurl = "";
        //if (currentActivity != null)
        //{
        //    nickname = currentActivity.Call<string>("getNickName");
        //    sex = currentActivity.Call<string>("getUserSex");
        //    headimgurl = currentActivity.Call<string>("getImageUrl");
        //}
        //if (func != null)
        //{
        //    func(nickname, sex, headimgurl);
        //}
    }

    public string GetData(string methodName)
    {
        if (currentActivity != null)
            return currentActivity.Call<string>(methodName);
        return "";
    }

    public void ShareTexture(Camera camera, Rect rect, int scene)
    {
        // 创建一个RenderTexture对象  
        RenderTexture rt = new RenderTexture((int)rect.width, (int)rect.height, 0);
        // 临时设置相关相机的targetTexture为rt, 并手动渲染相关相机  
        camera.targetTexture = rt;
        camera.Render();
        //ps: --- 如果这样加上第二个相机，可以实现只截图某几个指定的相机一起看到的图像。  
        //ps: camera2.targetTexture = rt;  
        //ps: camera2.Render();  
        //ps: -------------------------------------------------------------------  

        // 激活这个rt, 并从中中读取像素。  
        RenderTexture.active = rt;
        Texture2D screenShot = new Texture2D((int)rect.width, (int)rect.height, TextureFormat.RGB24, false);
        screenShot.ReadPixels(rect, 0, 0);// 注：这个时候，它是从RenderTexture.active中读取像素  
        screenShot.Apply();

        // 重置相关参数，以使用camera继续在屏幕上显示  
        camera.targetTexture = null;
        //ps: camera2.targetTexture = null;  
        RenderTexture.active = null; // JC: added to avoid errors  
        GameObject.Destroy(rt);
        // 最后将这些纹理数据，成一个png图片文件  
        byte[] bytes = screenShot.EncodeToPNG();
        //string filename = Application.dataPath + "/Screenshot.png";
        //System.IO.File.WriteAllBytes(filename, bytes);
        if (currentActivity != null)
        {
            currentActivity.Call("wxShareTexture", bytes, scene);
        }
    }

    [CSharpCallLua]
    public delegate void paraIntDelegate(int para);
    public paraIntDelegate onSignalLevel = null;

    public void OnSignalStrengthListener(string level)
    {
        if (onSignalLevel != null)
            onSignalLevel(int.Parse(level));
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
