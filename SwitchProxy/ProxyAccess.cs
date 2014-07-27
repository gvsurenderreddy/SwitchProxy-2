using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace SwitchProxy
{
    public class ProxyAccess
    {
        // Refreshes system proxy settings
        [DllImport("wininet.dll")]
        public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);
        private const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        private const int INTERNET_OPTION_REFRESH = 37;

        private const String REGISTRY_PATH = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";
        private const String PROXY_ENABLED = "ProxyEnable";

        private static void refreshSettings()
        {
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
        }

        public static void setProxy(bool enabled)
        {
            int enableSetting;

            if (enabled)
            {
                enableSetting = 1;
            }
            else
            {
                enableSetting = 0;
            }

            RegistryKey rk = Registry.CurrentUser.OpenSubKey(REGISTRY_PATH, true);
            rk.SetValue(PROXY_ENABLED, enableSetting);
            rk.Close();
            refreshSettings();
        }
    }
}
