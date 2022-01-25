using InstallerPP.Reg;
using System;

internal class Program
{
    static void Main(string[] args)
    {
        IPPRegistry reg = new IPPRegistry(@"SOFTWARE\Valve\Hammer\General");
        string result = reg.GetKeyValue("Directory");
        Console.WriteLine(result);
    }
}