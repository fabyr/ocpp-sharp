using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct Modem
    {
        public static readonly Modem Empty = new Modem();

        public CiString iccid;
        public CiString imsi;
    }
}