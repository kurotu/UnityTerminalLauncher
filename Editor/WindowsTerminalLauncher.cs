using System.Diagnostics;

namespace KRT.UnityTerminalLauncher
{
    class WindowsTerminalLauncher : TerminalLauncher
    {
        internal override bool HasExecutable => ExistsOnPath("wt.exe");

        internal override Process Launch(string targetFolder)
        {
            return Process.Start("wt.exe", $"-d \"{targetFolder}\"");
        }
    }
}
