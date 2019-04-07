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
    /// Class to implement the XBee command " OTA Firmware Update Status ".
    /// The Over-the-Air Firmware Update Status frame provides an indication of the status of a
    /// firmware update transmission attempt. A query command (0x01 0x51) sent to a target with a
    /// 64-bit address of 0x0013A200 40522BAA through an updater with 64-bit address
    /// 0x0013A200403E0750 and 16-bit address 0x0000, generates the following expected
    /// response. 
    ///This class provides methods for processing XBee API commands.
    ///
    /// </summary>
    public class XBeeOtaFirmwareUpdateStatusEvent : XBeeFrame, IXBeeEvent
    {
        
        /// <summary>
        /// Response field
        /// MSB first, LSB last. The address of the remote radio returning this response. 
        ///
        /// </summary>
        private IeeeAddress _ieeeAddress;
        
        /// <summary>
        /// Response field
        /// The 16-bit address of the updater device.
        ///
        /// </summary>
        private int _networkAddress;
        
        /// <summary>
        /// Response field
        ///
        /// </summary>
        private ReceiveOptions _receiveOptions;
        
        /// <summary>
        /// Response field
        /// Block number used in the update request. Set to 0 if not applicable. 
        ///
        /// </summary>
        private int _blockNumber;
        
        /// <summary>
        /// Response field
        /// The 64-bit Address of remote device that is being updated (target) 
        ///
        /// </summary>
        private IeeeAddress _targetAddress;
        
        /// <summary>
        /// Return the ieeeAddress as <see cref="IeeeAddress"/>
        /// </summary>
        public IeeeAddress GetIeeeAddress()
        {
            return _ieeeAddress;
        }
        
        /// <summary>
        /// Return the networkAddress as <see cref="System.Int32"/>
        /// </summary>
        public int GetNetworkAddress()
        {
            return _networkAddress;
        }
        
        /// <summary>
        /// Return the receiveOptions as <see cref="ReceiveOptions"/>
        /// </summary>
        public ReceiveOptions GetReceiveOptions()
        {
            return _receiveOptions;
        }
        
        /// <summary>
        /// Return the blockNumber as <see cref="System.Int32"/>
        /// </summary>
        public int GetBlockNumber()
        {
            return _blockNumber;
        }
        
        /// <summary>
        /// Return the targetAddress as <see cref="IeeeAddress"/>
        /// </summary>
        public IeeeAddress GetTargetAddress()
        {
            return _targetAddress;
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
