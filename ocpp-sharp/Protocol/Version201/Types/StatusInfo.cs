using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct StatusInfo
    {
        public static readonly StatusInfo Empty = new StatusInfo();

        public CiString reasonCode;
        public string? additionalInfo;
    }
}