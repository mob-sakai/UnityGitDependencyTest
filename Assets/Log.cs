using System.IO;
using System.Text;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class LogInstalledPackage : MonoBehaviour
{
	[InitializeOnLoadMethod]
	static void InitializeOnLoadMethod()
	{
		EditorApplication.projectChanged += Log;
		Log();
	}

	const System.StringComparison Ordinal = System.StringComparison.Ordinal;

	static PackageJson[] GetInstalledPackages()
	{
		//return Directory.GetDirectories ("./Library/PackageCache")
		//	.Concat (Directory.GetDirectories ("./Packages"))
		//	.Select (PackageMeta.FromPackageDir)    // Convert to PackageMeta
		//	.Where (x => x != null)                 // Skip null
		//	.ToArray ();
		return AssetDatabase.GetAllAssetPaths()
			.Where(x => x.StartsWith("Packages/", Ordinal) && x.EndsWith("/package.json", Ordinal))
			.Where(x=>File.Exists(x))
			.Select(x=>JsonUtility.FromJson<PackageJson>(File.ReadAllText(x)))    // Convert to PackageMeta
			.Where(x => x != null)                  // Skip null
			.ToArray();
	}

	[MenuItem("Test/LogInstalledPackage")]
	static void Log()
	{
		var packages = GetInstalledPackages()
			.Where(x => x.name.Contains("com.coffee.package") || x.name.Contains("com.unity.ads"));
			;

		StringBuilder sb = new StringBuilder("★★ Installed Packages:\n");
		foreach (var package in packages)
		{
			sb.AppendFormat("  -> {0}: {1}\n", package.name, package.version);
		}
		Debug.Log(sb);

		File.WriteAllText("installedPackages.txt", sb.ToString());
	}

	[System.Serializable]
	public class PackageJson
	{
		public string name;
		public string version;
	}
}
