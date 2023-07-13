using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct APN
    {
        public static readonly APN Empty = new APN();

        public string apn;
        public string? apnUserName;
        public string? apnPassword;
        public int? simPin;
        public CiString? preferredNetwork;
        public bool? useOnlyPreferredNetwork;
        public APNAuthenticationType.Enum apnAuthentication;
    }
}