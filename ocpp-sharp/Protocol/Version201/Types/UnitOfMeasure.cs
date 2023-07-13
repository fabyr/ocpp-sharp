using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct UnitOfMeasure
    {
        public static readonly UnitOfMeasure Empty = new UnitOfMeasure();

        public string? unit; // From list of Standardized Units in Part 2 Appendices

        /// <summary>
        /// The value is multiplied by 10^multiplier (power)
        /// </summary>
        public int? multiplier; // Default is 0
    }
}