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
    /// Class to implement the XBee command " PAN ID ".
    /// AT Command <b>OI</b></p>Read the 16-bit PAN ID. The OI value reflects the actual 16-bit PAN
    /// ID where the device is running. 
    ///This class provides methods for processing XBee API commands.
    ///
    /// </summary>
    public class XBeePanIdResponse : XBeeFrame, IXBeeResponse 
    {
        
        /// <summary>
        /// Response field
        ///
        /// </summary>
        private int _frameId;
        
        /// <summary>
        /// Response field
        ///
        /// </summary>
        private CommandStatus _commandStatus;
        
        /// <summary>
        /// Response field
        ///
        /// </summary>
        private int _panId;
        
        /// <summary>
        /// Return the frameId as <see cref="System.Int32"/>
        /// </summary>
        public int GetFrameId()
        {
            return _frameId;
        }
        
        /// <summary>
        /// Return the commandStatus as <see cref="CommandStatus"/>
        /// </summary>
        public CommandStatus GetCommandStatus()
        {
            return _commandStatus;
        }
        
        /// <summary>
        /// Return the panId as <see cref="System.Int32"/>
        /// </summary>
        public int GetPanId()
        {
            return _panId;
        }
        
        /// <summary>
        /// Method for deserializing the fields for the response
        ///
        /// </summary>
        public void Deserialize(int[] incomingData)
        {
            this.InitializeDeserializer(incomingData);
        }
    }
}
