using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class ConnectorType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(ConnectorType.cCCS1)]
        cCCS1,

        [StringValue(ConnectorType.cCCS2)]
        cCCS2,

        [StringValue(ConnectorType.cG105)]
        cG105,

        [StringValue(ConnectorType.cTesla)]
        cTesla,

        [StringValue(ConnectorType.cType1)]
        cType1,

        [StringValue(ConnectorType.cType2)]
        cType2,

        [StringValue(ConnectorType.s309_1P_16A)]
        s309_1P_16A,

        [StringValue(ConnectorType.s309_1P_32A)]
        s309_1P_32A,

        [StringValue(ConnectorType.s309_3P_16A)]
        s309_3P_16A,

        [StringValue(ConnectorType.s309_3P_32A)]
        s309_3P_32A,

        [StringValue(ConnectorType.sBS1361)]
        sBS1361,

        [StringValue(ConnectorType.sCEE_7_7)]
        sCEE_7_7,

        [StringValue(ConnectorType.sType2)]
        sType2,

        [StringValue(ConnectorType.sType3)]
        sType3,

        [StringValue(ConnectorType.Other1PhMax16A)]
        Other1PhMax16A,

        [StringValue(ConnectorType.Other1PhOver16A)]
        Other1PhOver16A,

        [StringValue(ConnectorType.Other3Ph)]
        Other3Ph,

        [StringValue(ConnectorType.Pan)]
        Pan,

        [StringValue(ConnectorType.wInductive)]
        wInductive,

        [StringValue(ConnectorType.wResonant)]
        wResonant,

        [StringValue(ConnectorType.Undetermined)]
        Undetermined,

        [StringValue(ConnectorType.Unknown)]
        Unknown
    }

    public const string cCCS1 = "cCCS1";
    public const string cCCS2 = "cCCS2";
    public const string cG105 = "cG105";
    public const string cTesla = "cTesla";
    public const string cType1 = "cType1";
    public const string cType2 = "cType2";
    public const string s309_1P_16A = "s309-1P-16A";
    public const string s309_1P_32A = "s309-1P-32A";
    public const string s309_3P_16A = "s309-3P-16A";
    public const string s309_3P_32A = "s309-3P-32A";
    public const string sBS1361 = "sBS1361";
    public const string sCEE_7_7 = "sCEE-7-7";
    public const string sType2 = "sType2";
    public const string sType3 = "sType3";
    public const string Other1PhMax16A = "Other1PhMax16A";
    public const string Other1PhOver16A = "Other1PhOver16A";
    public const string Other3Ph = "Other3Ph";
    public const string Pan = "Pan";
    public const string wInductive = "wInductive";
    public const string wResonant = "wResonant";
    public const string Undetermined = "Undetermined";
    public const string Unknown = "Unknown";
}
