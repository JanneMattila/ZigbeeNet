//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:3.0.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZigBeeNet.Hardware.Ember.Ezsp.Command
{
    using ZigBeeNet.Hardware.Ember.Internal.Serializer;
    using ZigBeeNet.Hardware.Ember.Ezsp.Structure;
    
    
    /// <summary>
    /// Class to implement the Ember EZSP command " setConfigurationValue ".
    /// Writes a configuration value to the NCP. Configuration values can be modified by the Host
    /// after the NCP has reset. Once the status of the stack changes to EMBER_NETWORK_UP,
    /// configuration values can no longer be modified and this command will respond with
    /// EZSP_ERROR_INVALID_CALL.
    /// This class provides methods for processing EZSP commands.
    /// </summary>
    public class EzspSetConfigurationValueRequest : EzspFrameRequest
    {
        
        public const int FRAME_ID = 83;
        
        /// <summary>
        ///  Identifies which configuration value to change.
        /// </summary>
        private EzspConfigId _configId;
        
        /// <summary>
        ///  The new configuration value.
        /// </summary>
        private int _value;
        
        private EzspSerializer _serializer;
        
        public EzspSetConfigurationValueRequest()
        {
            _frameId = FRAME_ID;
            _serializer = new EzspSerializer();
        }
        
        /// <summary>
        /// The configId to set as <see cref="EzspConfigId"/> </summary>
        public void SetConfigId(EzspConfigId configId)
        {
            _configId = configId;
        }
        
        /// <summary>
        /// The value to set as <see cref="uint16_t"/> </summary>
        public void SetValue(int value)
        {
            _value = value;
        }
        
        /// <summary>
        ///  Identifies which configuration value to change.
        /// Return the configId as <see cref="EzspConfigId"/>
        /// </summary>
        public EzspConfigId GetConfigId()
        {
            return _configId;
        }
        
        /// <summary>
        ///  The new configuration value.
        /// Return the value as <see cref="System.Int32"/>
        /// </summary>
        public int GetValue()
        {
            return _value;
        }
        
        /// <summary>
        /// Method for serializing the command fields </summary>
        public override int[] Serialize()
        {
            SerializeHeader(_serializer);
            _serializer.SerializeEzspConfigId(_configId);
            _serializer.SerializeUInt16(_value);
            return _serializer.GetPayload();
        }
        
        public override string ToString()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            builder.Append("EzspSetConfigurationValueRequest [configId=");
            builder.Append(_configId);
            builder.Append(", value=");
            builder.Append(_value);
            builder.Append(']');
            return builder.ToString();
        }
    }
}