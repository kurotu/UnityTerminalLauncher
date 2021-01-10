#if UNITY_EDITOR_WIN
using UnityEditor;
using UnityEngine;
using Microsoft.Win32;
using System.IO;

public class UnityGitBashHere
{
    [MenuItem("Assets/Git Bash Here")]
    private static void GitBashHere()
    {
        var path = GetSelectedPathOrFallback();
        var cd = Path.Combine(GetProjectPath(), path).Replace('/', '\\');
        OpenGitBash(GetGitInstallPath(), cd);
    }

    [MenuItem("Assets/Git Bash Here", true)]
    private static bool Validate()
    {
        var gitPath = GetGitInstallPath();
        return !string.IsNullOrEmpty(gitPath);
    }

    private static string GetProjectPath()
    {
        var assetsPath = Application.dataPath;
        return assetsPath.Substring(0, assetsPath.Length - "Assets".Length).Replace(":/", "://");
    }

    private static string GetSelectedPathOrFallback()
    {
        string path = "Assets";

        foreach (var obj in Selection.GetFiltered(typeof(Object), SelectionMode.Assets))
        {
            path = AssetDatabase.GetAssetPath(obj);
            if (!string.IsNullOrEmpty(path) && File.Exists(path))
            {
                path = Path.GetDirectoryName(path);
                break;
            }
        }
        return path;
    }

    private static string GetGitInstallPath()
    {
        const string key = "HKEY_LOCAL_MACHINE\\SOFTWARE\\GitForWindows";
        var path = (string)Registry.GetValue(key, "InstallPath", "");
        return path;
    }

    private static void OpenGitBash(string gitInstallPath, string path)
    {
        var gitBash = System.IO.Path.Combine(gitInstallPath, "git-bash.exe");
        System.Diagnostics.Process.Start(gitBash, string.Format("--cd=\"{0}\"", path));
    }
}
#endif
