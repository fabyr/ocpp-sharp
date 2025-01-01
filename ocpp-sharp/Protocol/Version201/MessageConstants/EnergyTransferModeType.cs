using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class EnergyTransferModeType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(EnergyTransferModeType.DC)]
        DC,

        [StringValue(EnergyTransferModeType.AC_single_phase)]
        AC_single_phase,

        [StringValue(EnergyTransferModeType.AC_two_phase)]
        AC_two_phase,

        [StringValue(EnergyTransferModeType.AC_three_phase)]
        AC_three_phase
    }

    public const string DC = "DC";
    public const string AC_single_phase = "AC_single_phase";
    public const string AC_two_phase = "AC_two_phase";
    public const string AC_three_phase = "AC_three_phase";
}
