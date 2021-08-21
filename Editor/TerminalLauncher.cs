using System.Diagnostics;

namespace KRT.UnityTerminalLauncher
{
    abstract class TerminalLauncher
    {
        internal abstract Process Launch(string targetFolder);
    }
}
