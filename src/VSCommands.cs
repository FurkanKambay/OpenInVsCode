namespace OpenInVsCode
{
    using System;
    
    /// <summary>
    /// Helper class that exposes all GUIDs used across VS Package.
    /// </summary>
    internal sealed partial class PackageGuids
    {
        public const string guidPackageString = "0a3cf9fa-2fe6-42dc-97df-a0f224cf5854";
        public const string guidOpenInVsCmdSetString = "cad3eff2-bd57-4dd4-9104-7b032daeba54";
        public static Guid guidPackage = new Guid(guidPackageString);
        public static Guid guidOpenInVsCmdSet = new Guid(guidOpenInVsCmdSetString);
    }
    /// <summary>
    /// Helper class that encapsulates all CommandIDs uses across VS Package.
    /// </summary>
    internal sealed partial class PackageIds
    {
        public const int OpenInVs = 0x0100;
    }
}
