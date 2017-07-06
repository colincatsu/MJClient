using UnityEditor;
using System.IO;
using System.Collections;
using UnityEngine;
using System.Collections.Generic;

//build and copy helper
class PerformBuild
{
	//you need to change this var to your android folder name
	//here it means ../android
	static string androidFolderName = "MJAndroid/MJProject";

	[UnityEditor.MenuItem("Tools/Build Android &2")]
	static void CommandLineBuildAndroid()
	{
		Debug.Log("Command line build android version\n------------------\n------------------");

		string[] scenes = GetBuildScenes();
		string path = GetBuildPath("build/android") + "/android.apk";

		if (scenes == null || scenes.Length == 0 || path == null)
			return;

		//EditorUtility.DisplayDialog("Objects exported", "Exported objects", "");
		Debug.Log(string.Format("Path: \"{0}\"", path));

		for (int i = 0; i < scenes.Length; ++i) {
			Debug.Log(string.Format("Scene[{0}]: \"{1}\"", i, scenes[i]));
		}

		Debug.Log("Starting Android Build!");
		BuildPipeline.BuildPlayer(scenes, path, BuildTarget.Android, BuildOptions.None);
		//delete the android assets and libs folder to make sure it is the newest
		DeleteDirectory("../" + androidFolderName + "/assets/bin");
		//DeleteDirectory("../" + androidFolderName + "/assets/libs");
		CopyDirectory("Temp/StagingArea/assets/", "../" + androidFolderName + "/assets/");
		//CopyDirectory("Temp/StagingArea/libs/armeabi", "../" + androidFolderName + "/libs/armeabi");

		EditorUtility.DisplayDialog("", "Completed!", "ok");
	}
	//
	//	[UnityEditor.MenuItem("Tools/Build iOS &3")]
	//	static void CommandLineBuildiOS()
	//	{
	//		Debug.Log("Command line build ios version\n------------------\n------------------");
	//
	//		string[] scenes = GetBuildScenes();
	//		string path = GetBuildPath(Application.dataPath + "/../../buildios");
	//		if (scenes == null || scenes.Length == 0 || path == null)
	//			return;
	//
	//		Debug.Log(string.Format("Path: \"{0}\"", path));
	//		for (int i = 0; i < scenes.Length; ++i) {
	//			Debug.Log(string.Format("Scene[{0}]: \"{1}\"", i, scenes[i]));
	//		}
	//
	//		Debug.Log("Starting Build!");
	//		UnityEditor.BuildPipeline.BuildPlayer(scenes, path, UnityEditor.BuildTarget.iPhone, UnityEditor.BuildOptions.None);
	//
	//		EditorUtility.DisplayDialog("", "Completed!", "ok");
	//	}

	static string[] GetBuildScenes()
	{
		List<string> names = new List<string>();

		foreach (EditorBuildSettingsScene e in EditorBuildSettings.scenes) {
			if (e == null)
				continue;

			if (e.enabled)
				names.Add(e.path);
		}

		return names.ToArray();
	}

	static string GetBuildPath(string dirPath)
	{
		if (!System.IO.Directory.Exists(dirPath)) {
			System.IO.Directory.CreateDirectory(dirPath);
		}

		return dirPath;
	}

	public static void DeleteDirectory(string path)
	{
		DirectoryInfo dir = new DirectoryInfo(path);

		if (dir.Exists) {
			dir.Delete(true);
		}
	}

	public static void CopyDirectory(string sourceDirectory, string destDirectory)
	{
		if (!Directory.Exists(sourceDirectory)) {
			Directory.CreateDirectory(sourceDirectory);
		}

		if (!Directory.Exists(destDirectory)) {
			Directory.CreateDirectory(destDirectory);
		}

		if (sourceDirectory.EndsWith("/"))
			sourceDirectory = sourceDirectory.Substring(0, sourceDirectory.Length - 1);

		if (destDirectory.EndsWith("/"))
			destDirectory = destDirectory.Substring(0, destDirectory.Length - 1);

		Debug.Log("copy directory: [" + sourceDirectory + "] to:[" + destDirectory + "]");

		CopyFile(sourceDirectory, destDirectory);

		string[] directionName = Directory.GetDirectories(sourceDirectory);

		foreach (string directionPath in directionName) {
			string directionPathTemp = destDirectory + "/"
			                           + directionPath.Substring(sourceDirectory.Length);
			CopyDirectory(directionPath, directionPathTemp);
		}
	}

	public static void CopyFile(string sourceDirectory, string destDirectory)
	{
		string[] fileName = Directory.GetFiles(sourceDirectory);

		foreach (string filePath in fileName) {
			string filePathTemp = destDirectory + "/" + filePath.Substring(sourceDirectory.Length);

			if (File.Exists(filePathTemp)) {
				File.Copy(filePath, filePathTemp, true);
			} else {
				File.Copy(filePath, filePathTemp);
			}
		}
	}
}