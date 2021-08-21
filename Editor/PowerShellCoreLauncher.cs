using System.Diagnostics;

namespace KRT.UnityTerminalLauncher
{
    class PowerShellCoreLauncher : TerminalLauncher
    {
        internal override bool HasExecutable => ExistsOnPath("pwsh.exe");

        internal override Process Launch(string targetFolder)
        {
            var processInfo = new ProcessStartInfo("pwsh.exe")
            {
                WorkingDirectory = targetFolder,
            };
            return Process.Start(processInfo);
        }
    }
}
