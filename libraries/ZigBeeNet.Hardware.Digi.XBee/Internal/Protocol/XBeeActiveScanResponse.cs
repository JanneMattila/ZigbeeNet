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
    /// Class to implement the XBee command " Active Scan ".
    /// AT Command <b>AS</b></p>Scans the neighborhood for beacon responses. The AS command is
    /// only valid as a local command. 
    /// This class provides methods for processing XBee API commands.
    /// </summary>
    public class XBeeActiveScanResponse : XBeeFrame, IXBeeResponse 
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
        /// Response field
        /// </summary>
        private int _asType;
        
        /// <summary>
        /// Response field
        /// </summary>
        private int _channel;
        
        /// <summary>
        /// Response field
        /// </summary>
        private ExtendedPanId _extendedPanId;
        
        /// <summary>
        /// Response field
        /// </summary>
        private bool _allowJoin;
        
        /// <summary>
        /// Response field
        /// </summary>
        private int _stackProfile;
        
        /// <summary>
        /// Response field
        /// </summary>
        private int _lqi;
        
        /// <summary>
        /// Response field
        /// </summary>
        private int _rssi;
        
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
        ///  Return the asType as <see cref="System.Int32"/>
        /// </summary>
        public int GetAsType()
        {
            return _asType;
        }
        
        /// <summary>
        ///  Return the channel as <see cref="System.Int32"/>
        /// </summary>
        public int GetChannel()
        {
            return _channel;
        }
        
        /// <summary>
        ///  Return the extendedPanId as <see cref="ExtendedPanId"/>
        /// </summary>
        public ExtendedPanId GetExtendedPanId()
        {
            return _extendedPanId;
        }
        
        /// <summary>
        ///  Return the allowJoin as <see cref="System.Boolean"/>
        /// </summary>
        public bool GetAllowJoin()
        {
            return _allowJoin;
        }
        
        /// <summary>
        ///  Return the stackProfile as <see cref="System.Int32"/>
        /// </summary>
        public int GetStackProfile()
        {
            return _stackProfile;
        }
        
        /// <summary>
        ///  Return the lqi as <see cref="System.Int32"/>
        /// </summary>
        public int GetLqi()
        {
            return _lqi;
        }
        
        /// <summary>
        ///  Return the rssi as <see cref="System.Int32"/>
        /// </summary>
        public int GetRssi()
        {
            return _rssi;
        }
        
        /// <summary>
        /// Method for deserializing the fields for the response </summary>
        public void Deserialize(int[] incomingData)
        {
            InitializeDeserializer(incomingData);
            _frameId = DeserializeInt8();
            DeserializeAtCommand();
            _commandStatus = DeserializeCommandStatus();
            if (_commandStatus != CommandStatus.OK || IsComplete())
            {
                    return;
            }
            _asType = DeserializeInt8();
            _channel = DeserializeInt8();
            _extendedPanId = DeserializeExtendedPanId();
            _allowJoin = DeserializeBoolean();
            _stackProfile = DeserializeInt8();
            _lqi = DeserializeInt8();
            _rssi = DeserializeInt8();
        }
        
        public override string ToString()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder(1012);
            builder.Append("XBeeActiveScanResponse [frameId=");
            builder.Append(_frameId);
            builder.Append(", commandStatus=");
            builder.Append(_commandStatus);
            builder.Append(_asType);
            builder.Append(_channel);
            builder.Append(_extendedPanId);
            builder.Append(_allowJoin);
            builder.Append(_stackProfile);
            builder.Append(_lqi);
            builder.Append(_rssi);
            builder.Append(']');
            return builder.ToString();
        }
    }
}
