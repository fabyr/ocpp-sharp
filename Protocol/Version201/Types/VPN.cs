using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct VPN
    {
        public static readonly VPN Empty = new VPN();

        public string server;
        public string user;
        public string? group;
        public string password;
        public string key;
        public VPNType.Enum type;
    }
}