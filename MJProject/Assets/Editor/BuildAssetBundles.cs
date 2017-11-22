using UnityEngine;
using UnityEditor;
using System.IO;

public class BuildAssetBundles
{
	[MenuItem("Window/Build FairyGUI Android Bundles")]
	public static void Builde()
	{
#if UNITY_5
        AssetImporter.GetAtPath("Assets/FairyGUI/FairyUI/MXUI.bytes").assetBundleName = "mx_assetbundles_android/mxui.ab";
        AssetImporter.GetAtPath("Assets/FairyGUI/FairyUI/MXUI@sprites.bytes").assetBundleName = "mx_assetbundles_android/mxui.ab";
        AssetImporter.GetAtPath("Assets/FairyGUI/FairyUI/MXUI@atlas0.png").assetBundleName = "mx_assetbundles_android/mxui.ab";
        AssetImporter.GetAtPath("Assets/FairyGUI/FairyUI/MXUI@atlas0_1.png").assetBundleName = "mx_assetbundles_android/mxui.ab";
        AssetImporter.GetAtPath("Assets/FairyGUI/FairyUI/MXUI@atlas0_2.png").assetBundleName = "mx_assetbundles_android/mxui.ab";
        AssetImporter.GetAtPath("Assets/FairyGUI/FairyUI/MXUI@atlas3.png").assetBundleName = "mx_assetbundles_android/mxui.ab";

        BuildPipeline.BuildAssetBundles(Application.streamingAssetsPath, BuildAssetBundleOptions.None, BuildTarget.Android);
        AssetDatabase.Refresh();
#else
		for (int i = 0; i < 10; i++)
		{
			Object obj = AssetDatabase.LoadAssetAtPath("Assets/FairyGUI/Examples/Resources/Icons/i"+i+".png", typeof(Object));
			BuildPipeline.BuildAssetBundle(obj, null, Path.Combine(Application.streamingAssetsPath, "fairygui-examples/i" + i + ".ab"), 
				BuildAssetBundleOptions.CollectDependencies, BuildTarget.Android);
		}

		Object mainAsset = AssetDatabase.LoadAssetAtPath("Assets/FairyGUI/Examples/Resources/UI/BundleUsage.bytes", typeof(Object));
		Object[] assets = new Object[] { 
			AssetDatabase.LoadAssetAtPath("Assets/FairyGUI/Examples/Resources/UI/BundleUsage@sprites.bytes", typeof(Object)),
			AssetDatabase.LoadAssetAtPath("Assets/FairyGUI/Examples/Resources/UI/BundleUsage@atlas0.png", typeof(Object))
		};

		BuildPipeline.BuildAssetBundle(mainAsset, assets, Path.Combine(Application.streamingAssetsPath, "fairygui-examples/bundleusage.ab"), 
			BuildAssetBundleOptions.CollectDependencies, BuildTarget.Android);
		AssetDatabase.Refresh();
#endif
    }

    [MenuItem("Window/Build FairyGUI Ios Bundles")]
    public static void BuildeIos()
    {
        AssetImporter.GetAtPath("Assets/FairyGUI/FairyUI/MXUI.bytes").assetBundleName = "mx_assetbundles_ios/mxui.ab";
        AssetImporter.GetAtPath("Assets/FairyGUI/FairyUI/MXUI@sprites.bytes").assetBundleName = "mx_assetbundles_ios/mxui.ab";
        AssetImporter.GetAtPath("Assets/FairyGUI/FairyUI/MXUI@atlas0.png").assetBundleName = "mx_assetbundles_ios/mxui.ab";
        AssetImporter.GetAtPath("Assets/FairyGUI/FairyUI/MXUI@atlas0_1.png").assetBundleName = "mx_assetbundles_ios/mxui.ab";
        AssetImporter.GetAtPath("Assets/FairyGUI/FairyUI/MXUI@atlas0_2.png").assetBundleName = "mx_assetbundles_ios/mxui.ab";
        AssetImporter.GetAtPath("Assets/FairyGUI/FairyUI/MXUI@atlas3.png").assetBundleName = "mx_assetbundles_ios/mxui.ab";

        BuildPipeline.BuildAssetBundles(Application.streamingAssetsPath, BuildAssetBundleOptions.None, BuildTarget.iOS);
        AssetDatabase.Refresh();
    }
}