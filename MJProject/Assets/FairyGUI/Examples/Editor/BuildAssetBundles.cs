using UnityEngine;
using UnityEditor;
using System.IO;

public class BuildAssetBundles
{
	[MenuItem("Window/Build FairyGUI Example Bundles")]
	public static void Builde()
	{
#if UNITY_5
        AssetImporter.GetAtPath("Assets/Resources/FairyUI/MXUI.bytes").assetBundleName = "mx_assetbundles/mxui.ab";
        AssetImporter.GetAtPath("Assets/Resources/FairyUI/MXUI@sprites.bytes").assetBundleName = "mx_assetbundles/mxui.ab";
        AssetImporter.GetAtPath("Assets/Resources/FairyUI/MXUI@atlas0.png").assetBundleName = "mx_assetbundles/mxui.ab";
        AssetImporter.GetAtPath("Assets/Resources/FairyUI/MXUI@atlas0_1.png").assetBundleName = "mx_assetbundles/mxui.ab";
        AssetImporter.GetAtPath("Assets/Resources/FairyUI/MXUI@atlas3.png").assetBundleName = "mx_assetbundles/mxui.ab";

        BuildPipeline.BuildAssetBundles(Application.streamingAssetsPath, BuildAssetBundleOptions.None, BuildTarget.Android);
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
}