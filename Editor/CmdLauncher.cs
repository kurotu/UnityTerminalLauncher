using System.Diagnostics;

namespace KRT.UnityTerminalLauncher
{
    class CmdLauncher : TerminalLauncher
    {
        internal override bool HasExecutable => true;

        internal override Process Launch(string targetFolder)
        {
            var processInfo = new ProcessStartInfo("cmd.exe")
            {
                WorkingDirectory = targetFolder,
            };
            return Process.Start(processInfo);
        }
    }
}
