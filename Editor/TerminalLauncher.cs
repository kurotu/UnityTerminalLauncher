using System;
using System.Diagnostics;
using System.IO;

namespace KRT.UnityTerminalLauncher
{
    abstract class TerminalLauncher
    {
        internal abstract bool HasExecutable { get; }
        internal abstract Process Launch(string targetFolder);

        protected bool ExistsOnPath(string fileName)
        {
            return GetFullPath(fileName) != null;
        }

        private static string GetFullPath(string fileName)
        {
            if (File.Exists(fileName))
                return Path.GetFullPath(fileName);

            var values = Environment.GetEnvironmentVariable("PATH");
            foreach (var path in values.Split(Path.PathSeparator))
            {
                var fullPath = Path.Combine(path, fileName);
                if (File.Exists(fullPath))
                    return fullPath;
            }
            return null;
        }
    }
}
