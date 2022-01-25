namespace InstallerPP.Exceptions
{
    [Serializable]
    public class HammerKeyValueNotFoundException : Exception
    {
        public HammerKeyValueNotFoundException() { }

        public HammerKeyValueNotFoundException(string message) : base(message) { }
    }
}
