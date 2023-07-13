using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct LogParameters
    {
        public static readonly LogParameters Empty = new LogParameters();

        public string remoteLocation;
        public DateTime? oldestTimestamp;
        public DateTime? latestTimestamp;
    }
}