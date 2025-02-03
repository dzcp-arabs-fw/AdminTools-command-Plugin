using System;
using System.Collections.Generic;
using PluginFramework; // ✅ تأكد أن هذا هو `Namespace` الصحيح

namespace AdminTools
{
    public class AdminToolsPlugin : IPluginWithCommands
    {
        public string Name => "Admin Tools";
        public string Version => "1.0.0";

        public void OnLoad()
        {
            ServerConsole.AddLog($"✅ [{Name}] Plugin loaded successfully!", ConsoleColor.Green);
        }

        public List<string> GetCommands()
        {
            return new List<string>
            {
                "adminkick <player>",
                "adminban <player> <duration>",
                "adminmute <player>",
                "adminunmute <player>"
            };
        }
    }
}