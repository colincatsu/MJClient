using UnityEngine;
using System.Collections;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Security.Cryptography;
using XLua;
using gcloud_voice;
using FairyGUI;

[LuaCallCSharp]
public class Platform : MonoBehaviour {
    private static Platform _instance;
    private Texture[] myWXPic;
    private const int textureNum = 100;
    private Dictionary<int, int> code2PicID;
    private static int spriteCnt;
    public IGCloudVoice m_voiceengine = null;

    public const int GOODS_COUNT_PRICE = 6;
    //public static string[] productIdentifiers = new string[GOODS_COUNT_PRICE] { "xiangle_chaoyao_6yuan", "xiangle_chaoyao_30yuan",
    //    "xiangle_chaoyao_68yuan", "xiangle_chaoyao_128yuan",
    //    "xiangle_chaoyao_298yuan", "xiangle_chaoyao_618yuan"};
    //public static float[] GOODS_PRICE = new float[GOODS_COUNT_PRICE] { 6f, 30f, 68f, 128f, 298f, 618f};
    public static string[] productIdentifiers = new string[GOODS_COUNT_PRICE];
    public static float[] GOODS_PRICE = new float[GOODS_COUNT_PRICE];
    //public static string[] GOODS_MONEY = new string[GOODS_COUNT_PRICE] { "6", "30", "68", "128", "298", "618"};
    private StoreKitProduct[] products;

    private const string BuglyAppIDForAndroid = "8cb1c6ad59";

    public void startBilling()
    {
        ConfigureStoreKitEvents();
        EasyStoreKit.AssignIdentifiers(productIdentifiers);
        if (Application.internetReachability != NetworkReachability.NotReachable)
        {
            if (EasyStoreKit.CanMakePayments())
            {
                //nullify previously loaded products
                this.products = null;
                EasyStoreKit.LoadProducts();

            }
            else
            {
                //				message = "Application is not allowed to make payments!";
            }
        }
    }

    public void AddProductData(string productID,float goodPrice,int index)
    {
        if(index < GOODS_COUNT_PRICE)
        {
            productIdentifiers[index] = productID;
            GOODS_PRICE[index] = goodPrice;
        }
    }
    private void ConfigureStoreKitEvents()
    {
        EasyStoreKit.productsLoadedEvent += ProductsLoaded;
        EasyStoreKit.transactionPurchasedEvent += TransactionPurchased;
        EasyStoreKit.transactionFailedEvent += TransactionFailed;
        EasyStoreKit.transactionRestoredEvent += TransactionRestored;
        EasyStoreKit.transactionCancelledEvent += TransactionCancelled;
        EasyStoreKit.restoreCompletedEvent += RestoreCompleted;
        EasyStoreKit.restoreFailedEvent += RestoreFailed;
    }
    private void ProductsLoaded(StoreKitProduct[] products)
    {
        this.products = products;
    }
    [CSharpCallLua]
    public delegate void paraFloatDelegate(string paraStr, float paraFloat);
    public paraFloatDelegate onPurchaseSuccess = null;

    private void TransactionPurchased(string productIdentifier)
    {
        for (int i = 0; i < GOODS_COUNT_PRICE; i++)
        {
            if (productIdentifier.Equals(productIdentifiers[i]))
            {
                if(onPurchaseSuccess != null)
                {
                    onPurchaseSuccess(productIdentifiers[i], GOODS_PRICE[i]);
                }
            }
        }
    }

    public void callBilling(string identifier)
    {
        bool hasString = false;
        for(int i = 0; i < GOODS_COUNT_PRICE; i++)
        {
            if (products[i].identifier == identifier)
                hasString = true;
        }
        if (!hasString)
        {
            Debug.LogError("callBilling error: wrong id");
            return;
        }
        if (EasyStoreKit.BuyProductWithIdentifier(identifier, 1))
        {
            Debug.Log("identifier is right");
        }
    }

    private void TransactionFailed(string productIdentifier, string errorMessage)
    {
    }

    private void TransactionRestored(string productIdentifier)
    {

    }

    private void TransactionCancelled(string productIdentifier)
    {

    }

    private void RestoreCompleted()
    {

    }

    private void RestoreFailed(string errorMessage)
    {

    }

    [DllImport("__Internal")]
    private static extern void wxLogin();

    [DllImport("__Internal")]
    private static extern void wxCopyRoom(string roomID);

    [DllImport("__Internal")]
    private static extern void wxShare(string title, string desc, string url);

    [DllImport("__Internal")]
    private static extern void wxShareTexture(byte[] bytes,int byteLength, int scene);

    [DllImport("__Internal")]
    private static extern int getSignalStrength();

    [DllImport("__Internal")]
    private static extern bool isWXAppInstalled();

    [DllImport("__Internal")]
    private static extern string wxReadPaste();

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
                    _instance.gameObject.AddComponent<EasyStoreKit>();
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
        //if (LuaCommon.isIos)
        //{
        //    startBilling();
        //}
    }

    public static AndroidJavaClass jc;
    public static AndroidJavaObject currentActivity;

    void Init()
    {
        if (!Directory.Exists(Application.persistentDataPath + "/ImageCache/"))
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/ImageCache/");
        }
        myWXPic = new Texture[textureNum];
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
        InitBuglySDK(false);
    }

    public void InitGVoice(string appID, string appKey, string openID, string udpUrl)
    {
        if (m_voiceengine == null)
        {
            m_voiceengine = GCloudVoice.GetEngine();
            m_voiceengine.SetAppInfo(appID, appKey, openID);
            m_voiceengine.SetServerInfo(udpUrl);
            m_voiceengine.Init();
        }
    }

    public void InitBuglySDK(bool openSdk)
    {
#if DEBUG
        BuglyAgent.ConfigDebugMode(openSdk);
#endif
        BuglyAgent.ConfigDebugMode(openSdk);
#if UNITY_ANDROID
        BuglyAgent.InitWithAppId(BuglyAppIDForAndroid);
#endif

        // TODO Required. If you do not need call 'InitWithAppId(string)' to initialize the sdk(may be you has initialized the sdk it associated Android or iOS project),
        // please call this method to enable c# exception handler only.
        BuglyAgent.EnableExceptionHandler();
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
            if (spriteCnt >= textureNum)
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
    [CSharpCallLua]
    public delegate void shareDelegate();
    public shareDelegate onShareCallBack;

    public void OnShareSuccess()
    {
        if(onShareCallBack != null)
        {
            onShareCallBack();
        }
    }

    IEnumerator DownloadImage(string url, int code)
    {
        WWW www = new WWW(url);
        yield return www;

        Texture2D tex2d = www.texture;
        //将图片保存至缓存路径  
        //byte[] pngData = tex2d.EncodeToPNG();                         //将材质压缩成byte流  
        //File.WriteAllBytes(path + url.GetHashCode(), pngData);        //然后保存到本地  
        //myWXPic = (Texture)tex2d;
        if (!code2PicID.ContainsKey(code))
        {
        Debug.Log("downloading new image:" + path + url.GetHashCode());//url转换HD5作为名字  
            code2PicID[code] = spriteCnt;
            myWXPic[spriteCnt] = (Texture)tex2d;
            if (func != null)
            {
                func();
            }
            ++spriteCnt;
        }
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

    //系统
    public string GetSystemVersion()
    {
        if (currentActivity != null)
        {
            return currentActivity.Call<string>("getSystemVersion");
        }
        if (LuaCommon.isIos)
            return "";
        return "";
    }

    //型号
    public string GetSystemModel()
    {
        if (currentActivity != null)
        {
            return currentActivity.Call<string>("getSystemModel");
        }
        if (LuaCommon.isIos)
            return "";
        return "";
    }

    public string GetImei()
    {
        if (currentActivity != null)
        {
            return currentActivity.Call<string>("getImei");
        }
        if (LuaCommon.isIos)
            return "";
        return "";
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
        if (LuaCommon.isIos)
            wxLogin();
    }

    public int SignalUpdate()
    {
        if (LuaCommon.isIos)
            return getSignalStrength();
        return 0;
    }

    public void WXShare(string title,string description,string url)
    {
        if(currentActivity != null)
        {
            currentActivity.Call("wxShare",title,description,url);
        }
        if (LuaCommon.isIos)
            wxShare(title, description, url);
    }

    public void CopyRoomID(string roomid)
    {
        if (currentActivity != null)
        {
            currentActivity.Call("wxCopyRoom", roomid);
        }
        if (LuaCommon.isIos)
            wxCopyRoom(roomid);
    }

    public string ReadPaste()
    {
        if (currentActivity != null)
        {
            return currentActivity.Call<string>("wxReadPaste");
        }
        if (LuaCommon.isIos)
            return wxReadPaste();
        return "";
    }

    public bool isInstalledWX()
    {
        if (LuaCommon.isIos)
        {
            return isWXAppInstalled();
        }
        return true;
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
        if (LuaCommon.isIos)
            wxShareTexture(bytes, bytes.Length, scene);
    }

    [CSharpCallLua]
    public delegate void paraIntDelegate(int para);
    public paraIntDelegate onSignalLevel = null;

    public void OnSignalStrengthListener(string level)
    {
        if (onSignalLevel != null)
            onSignalLevel(int.Parse(level));
    }

    public string GetMd5String(string msg)
    {
        MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
        byte[] data = System.Text.Encoding.UTF8.GetBytes(msg);
        byte[] md5Data = md5.ComputeHash(data, 0, data.Length);
        md5.Clear();

        string destString = "";
        for (int i = 0; i < md5Data.Length; i++)
        {
            destString += System.Convert.ToString(md5Data[i], 16).PadLeft(2, '0');
        }
        destString = destString.PadLeft(32, '0');
        return destString;
    }

    public void MatTrackCutomKVEvent(string event_id, string key, string value)
    {
        if (currentActivity != null)
        {
            currentActivity.Call("MatTrackCutomKVEvent", event_id, key, value);
        }
    }

    public void MatTrackCutomEvent(string event_id, string args)
    {
        if (currentActivity != null)
        {
            currentActivity.Call("MatTrackCutomEvent", event_id, args);
        }
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
