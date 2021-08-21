using System.Diagnostics;

namespace KRT.UnityTerminalLauncher
{
    class PowerShellLauncher : TerminalLauncher
    {
        internal override bool HasExecutable => true;

        internal override Process Launch(string targetFolder)
        {
            var processInfo = new ProcessStartInfo("PowerShell.exe")
            {
                WorkingDirectory = targetFolder,
            };
            return Process.Start(processInfo);
        }
    }
}
