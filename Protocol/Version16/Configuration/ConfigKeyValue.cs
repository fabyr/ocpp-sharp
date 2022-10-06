using System;

namespace OcppSharp.Protocol.Version16.Configuration
{
    public enum ConfigKeyValue
    {
        #region "Core Profile"

        [ValidValues(typeof(bool))]
        AllowOfflineTxForUnknownId,

        [ValidValues(typeof(bool))]
        AuthorizationCacheEnabled,

        [ValidValues(typeof(bool))]
        AuthorizeRemoteTxRequests,

        [ValidValues(typeof(int))]
        BlinkRepeat,

        [ValueUnit("s")]
        [ValidValues(typeof(int))]
        ClockAlignedDataInterval,

        [ValueUnit("s")]
        [ValidValues(typeof(int))]
        ConnectionTimeOut,

        [ValidValues(typeof(int))]
        GetConfigurationMaxKeys,

        [ValueUnit("s")]
        [ValidValues(typeof(int))]
        HeartbeatInterval,

        [ValueRange(0, 100)]
        [ValueUnit("%")]
        [ValidValues(typeof(int))]
        LightIntensity,

        [ValidValues(typeof(bool))]
        LocalAuthorizeOffline,

        [ValidValues(typeof(bool))]
        LocalPreAuthorize,

        [ValueUnit("Wh")]
        [ValidValues(typeof(int))]
        MaxEnergyOnInvalidId,

        [ValueList]
        [ValidValues(typeof(MessageConstants.Measurand.Enum))]
        MeterValuesAlignedData,

        [ValidValues(typeof(int))]
        MeterValuesAlignedDataMaxLength,

        [ValueList]
        [ValidValues(typeof(MessageConstants.Measurand.Enum))]
        MeterValuesSampledData,

        [ValidValues(typeof(int))]
        MeterValuesSampledDataMaxLength,

        [ValueUnit("s")]
        [ValidValues(typeof(int))]
        MeterValueSampleInterval,

        [ValueUnit("s")]
        [ValidValues(typeof(int))]
        MinimumStatusDuration,

        [ValidValues(typeof(int))]
        NumberOfConnectors,

        [ValidValues(typeof(int))]
        ResetRetries,

        [ValueIndexed]
        [ValueList]
        [ValidValues(typeof(MessageConstants.ConnectorPhaseRotation.Enum))]
        ConnectorPhaseRotation,
        
        [ValidValues(typeof(int))]
        ConnectorPhaseRotationMaxLength,

        [ValidValues(typeof(bool))]
        StopTransactionOnEVSideDisconnect,

        [ValidValues(typeof(bool))]
        StopTransactionOnInvalidId,

        [ValueList]
        [ValidValues(typeof(MessageConstants.Measurand.Enum))]
        StopTxnAlignedData,

        [ValidValues(typeof(int))]
        StopTxnAlignedDataMaxLength,

        [ValueList]
        [ValidValues(typeof(MessageConstants.Measurand.Enum))]
        StopTxnSampledData,
        
        [ValidValues(typeof(int))]
        StopTxnSampledDataMaxLength,

        [ValueList]
        [ValidValues(typeof(MessageConstants.FeatureProfile.Enum))]
        SupportedFeatureProfiles,

        [ValidValues(typeof(int))]
        SupportedFeatureProfilesMaxLength,

        [ValidValues(typeof(int))]
        TransactionMessageAttempts,

        [ValueUnit("s")]
        [ValidValues(typeof(int))]
        TransactionMessageRetryInterval,

        [ValidValues(typeof(bool))]
        UnlockConnectorOnEVSideDisconnect,

        [ValueUnit("s")]
        [ValidValues(typeof(int))]
        WebSocketPingInterval,

        #endregion

        #region "Local Auth List Management Profile"

        [ValidValues(typeof(bool))]
        LocalAuthListEnabled,

        [ValidValues(typeof(int))]
        LocalAuthListMaxLength,

        [ValidValues(typeof(int))]
        SendLocalListMaxLength,

        #endregion
    
        #region "Reservation Profile"

        [ValidValues(typeof(bool))]
        ReserveConnectorZeroSupported,

        #endregion
    
        #region "Smart Charging Profile"

        [ValidValues(typeof(int))]
        ChargeProfileMaxStackLevel,

        [ValueList]
        [ValidValues(typeof(MessageConstants.ChargingRateUnitType.QuantityEnum))]
        ChargingScheduleAllowedChargingRateUnit,

        [ValidValues(typeof(int))]
        ChargingScheduleMaxPeriods,

        [ValidValues(typeof(bool))]
        ConnectorSwitch3to1PhaseSupported,

        [ValidValues(typeof(int))]
        MaxChargingProfilesInstalled,

        #endregion
    }
}