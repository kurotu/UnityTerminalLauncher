using System;
using UnityEditor;

namespace KRT.UnityTerminalLauncher
{
    static class TerminalSettings
    {
        private static class EditorPrefsKeys
        {
            private const string prefix = "KRT.UnityTerminalLauncher.";
            internal const string TerminalType = prefix + "TerminalType";
        }

        internal static TerminalType TerminalType
        {
            get
            {
                if (!EditorPrefs.HasKey(EditorPrefsKeys.TerminalType))
                {
                    return TerminalType.Auto;
                }
                var value = EditorPrefs.GetInt(EditorPrefsKeys.TerminalType);
                return (TerminalType)Enum.ToObject(typeof(TerminalType), value);
            }
            set
            {
                EditorPrefs.SetInt(EditorPrefsKeys.TerminalType, (int)value);
            }
        }

        internal static int TerminalTypeInt
        {
            get => (int)TerminalType;
            set
            {
                TerminalType = (TerminalType)Enum.ToObject(typeof(TerminalType), value);
            }
        }
    }

    enum TerminalType
    {
        Auto,
        WindowsTerminal,
        PowerShellCore,
        PowerShell,
        Cmd,
        GitBash,
    }
}
