using InstallerPP.Exceptions;
using Microsoft.Win32;

namespace InstallerPP.Reg
{
    public class IPPRegistry
    {
        private string HammerPlusPlusRegistryPath { get; set; }

        public IPPRegistry(string registryPath)
        {
            HammerPlusPlusRegistryPath = registryPath;
        }

        public string GetKeyValue(string key)
        {
            RegistryKey? regKey = Registry.CurrentUser.OpenSubKey(HammerPlusPlusRegistryPath);
            if(regKey == null)
            {
                throw new HammerRegistryPathNotFoundException("The Hammer registry key could not be found. Has Hammer been run on this PC before?");
            }

            string? keyValue = (string?)regKey.GetValue(key);

            regKey.Close();

            if (string.IsNullOrEmpty(keyValue))
            {
                throw new HammerKeyValueNotFoundException($"The {key} key could not be found in the Hammer registry path");
            }

            return keyValue;
        }
    }
}
