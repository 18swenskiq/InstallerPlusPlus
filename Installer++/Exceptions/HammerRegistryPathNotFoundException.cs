namespace InstallerPP.Exceptions
{
    [Serializable]
    public class HammerRegistryPathNotFoundException : Exception
    {
        public HammerRegistryPathNotFoundException() { }

        public HammerRegistryPathNotFoundException(string message) : base(message) { }
    }
}
