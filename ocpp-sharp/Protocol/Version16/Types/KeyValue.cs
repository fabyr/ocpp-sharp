using System;

namespace OcppSharp.Protocol.Version16.Types
{
    public struct KeyValue
    {
        public static readonly KeyValue Empty = new KeyValue();

        public CiString key;
        public bool @readonly;
        public CiString? value;
    }
}