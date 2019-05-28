//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZigBeeNet.Hardware.Digi.XBee.Internal.Protocol
{
    
    
    /// <summary>
    /// Class to implement the XBee command " Reset ".
    /// AT Command <b>RE</b></p>This command sets all parameters except ZS and KY to their default
    /// values. To change ZS and KY, you must explicitly set them. In order for the default parameters
    /// to persist through subsequent resets, send a separate WR command after RE. Read-only
    /// parameters are not directly affected by RE and reflect the current state of the device. 
    /// This class provides methods for processing XBee API commands.
    /// </summary>
    public class XBeeResetResponse : XBeeFrame, IXBeeResponse 
    {
        
        /// <summary>
        /// Response field
        /// </summary>
        private int _frameId;
        
        /// <summary>
        /// Response field
        /// </summary>
        private CommandStatus _commandStatus;
        
        /// <summary>
        ///  Return the frameId as <see cref="System.Int32"/>
        /// </summary>
        public int GetFrameId()
        {
            return _frameId;
        }
        
        /// <summary>
        ///  Return the commandStatus as <see cref="CommandStatus"/>
        /// </summary>
        public CommandStatus GetCommandStatus()
        {
            return _commandStatus;
        }
        
        /// <summary>
        /// Method for deserializing the fields for the response </summary>
        public void Deserialize(int[] incomingData)
        {
            InitializeDeserializer(incomingData);
            _frameId = DeserializeInt8();
            DeserializeAtCommand();
            _commandStatus = DeserializeCommandStatus();
        }
        
        public override string ToString()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder(377);
            builder.Append("XBeeResetResponse [frameId=");
            builder.Append(_frameId);
            builder.Append(", commandStatus=");
            builder.Append(_commandStatus);
            builder.Append(']');
            return builder.ToString();
        }
    }
}
