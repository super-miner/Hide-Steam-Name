using System.Reflection;
using HideSteamName;

#region Assembly attributes

[assembly: AssemblyVersion(PluginInfo.PLUGIN_VERSION)]
[assembly: AssemblyTitle(PluginInfo.PLUGIN_NAME + " (" + PluginInfo.PLUGIN_ID + ")")]
[assembly: AssemblyProduct(PluginInfo.PLUGIN_NAME)]

#endregion

namespace HideSteamName {
    internal static class PluginInfo {
        public const string PLUGIN_NAME = "Hide Steam Name";

        public const string PLUGIN_ID = "flowndev.com.hidesteamname";

        public const string PLUGIN_VERSION = "1.0.0";
    }
}