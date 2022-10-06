using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct NetworkConnectionProfile
    {
        public static readonly NetworkConnectionProfile Empty = new NetworkConnectionProfile();

        public OCPPVersionType.Enum ocppVersion;
        public OCPPTransportType.Enum ocppTransport;
        public string ocppCsmsUrl;
        public int messageTimeout;
        public int securityProfile;
        public OCPPInterfaceType.Enum ocppInterface;
        public VPN? vpn;
        public APN? apn;
    }
}