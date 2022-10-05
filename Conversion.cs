using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OcppSharp
{
    public static class Conversion
    {
        // Convert every quantity to its base unit
        public static double ConvertToBase(double value, Protocol.Version16.MessageConstants.UnitOfMeasure.Enum? unit)
        {
            switch(unit)
            {
                default:
                    return value;
                case Protocol.Version16.MessageConstants.UnitOfMeasure.Enum.kW:
                case Protocol.Version16.MessageConstants.UnitOfMeasure.Enum.kWh:
                case Protocol.Version16.MessageConstants.UnitOfMeasure.Enum.kvarh:
                case Protocol.Version16.MessageConstants.UnitOfMeasure.Enum.kvar:
                    return value * 1000.0; // remove "k"
            }
        }
    }
}