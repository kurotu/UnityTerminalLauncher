using Microsoft.Win32;
using System.IO;
using System.Diagnostics;

namespace KRT.UnityTerminalLauncher
{
    class GitBashLauncher: TerminalLauncher
    {
        internal override bool HasExecutable => File.Exists(Path.Combine(GetGitInstallPath(), "git-bash.exe"));

        internal override Process Launch(string targetFolder)
        {
            var gitInstallPath = GetGitInstallPath();
            var gitBash = Path.Combine(gitInstallPath, "git-bash.exe");
            return Process.Start(gitBash, $"--cd=\"{targetFolder}\"");
        }

        private static string GetGitInstallPath()
        {
            const string key = "HKEY_LOCAL_MACHINE\\SOFTWARE\\GitForWindows";
            var path = (string)Registry.GetValue(key, "InstallPath", "");
            return path;
        }
    }
}
