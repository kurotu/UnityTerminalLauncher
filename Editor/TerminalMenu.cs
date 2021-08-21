using UnityEngine;
using UnityEditor;
using System.IO;

namespace KRT.UnityTerminalLauncher
{
    static class TerminalMenu
    {
        [MenuItem("Assets/Open Terminal Here")]
        private static void OpenTerminalHere()
        {
            var path = GetSelectedPathOrFallback();
            var cd = Path.Combine(GetProjectPath(), path).Replace('/', '\\');
            var launcher = CreateLauncher();
            launcher.Launch(cd);
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

        private static TerminalLauncher CreateLauncher()
        {
            return new WindowsTerminalLauncher();
        }
    }
}
