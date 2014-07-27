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
        private const String REGISTRY_PATH = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";

        private const String PROXY_ENABLED = "ProxyEnable";
        private const String PROXY_ADRESS = "ProxyServer";
        private const String PROXY_IGNORE_LOCAL_SETTINGS = "ProxyOverride";

        /// <summary>
        /// Sets the registry value of ProxyEnable
        /// </summary>
        /// <param name="enable">True if proxy should be used, false if not</param>
        public static void setProxy(bool enable)
        {
            int enableSetting;

            if (enable)
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
        }

        /// <summary>
        /// Sets the proxy IP and port. If parameter ipAndPort == "", the registry entry is deleted
        /// </summary>
        /// <param name="ipAndPort">IP:Port</param>
        public static void setIpAndPort(String ipAndPort)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(REGISTRY_PATH, true);
            if (ipAndPort == "")
            {
                if (rk.GetValue(PROXY_ADRESS) != null)
                {
                    rk.DeleteValue(PROXY_ADRESS);
                }
            }

            else
            {
                rk.SetValue(PROXY_ADRESS, ipAndPort);
            }

            rk.Close();
        }

        /// <summary>
        /// Sets the registry entry "Bypass proxy for local adresses
        /// </summary>
        /// <param name="ignore">True if proxy should be bypassed for local settings, false if not</param>
        public static void setIgnoreLocalSettings(bool ignore)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(REGISTRY_PATH, true);
            if (ignore)
            {
                String oldValue = (String)rk.GetValue(PROXY_IGNORE_LOCAL_SETTINGS);
                String newValue = oldValue;

                if (!oldValue.EndsWith(";<local>"))
                {
                    newValue = oldValue + ";<local>";
                }

                rk.SetValue(PROXY_IGNORE_LOCAL_SETTINGS, newValue);
            }

            else
            {
                rk.SetValue(PROXY_IGNORE_LOCAL_SETTINGS, "*.local");
            }

            rk.Close();
        }
    }
}
