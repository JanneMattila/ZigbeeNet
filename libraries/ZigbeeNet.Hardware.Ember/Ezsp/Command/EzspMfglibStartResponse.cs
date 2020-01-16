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
    /// Class to implement the Ember EZSP command " mfglibStart ".
    /// Activate use of mfglib test routines and enables the radio receiver to report packets it
    /// receives to the mfgLibRxHandler() callback. These packets will not be passed up with a CRC
    /// failure. All other mfglib functions will return an error until the mfglibStart() has been
    /// called
    /// This class provides methods for processing EZSP commands.
    /// </summary>
    public class EzspMfglibStartResponse : EzspFrameResponse
    {
        
        public const int FRAME_ID = 131;
        
        /// <summary>
        ///  The success or failure code of the operation.
        /// </summary>
        private EmberStatus _status;
        
        public EzspMfglibStartResponse(int[] inputBuffer) : 
                base(inputBuffer)
        {
            _status = deserializer.DeserializeEmberStatus();
        }
        
        /// <summary>
        /// The status to set as <see cref="EmberStatus"/> </summary>
        public void SetStatus(EmberStatus status)
        {
            _status = status;
        }
        
        /// <summary>
        ///  The success or failure code of the operation.
        /// Return the status as <see cref="EmberStatus"/>
        /// </summary>
        public EmberStatus GetStatus()
        {
            return _status;
        }
        
        public override string ToString()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            builder.Append("EzspMfglibStartResponse [status=");
            builder.Append(_status);
            builder.Append(']');
            return builder.ToString();
        }
    }
}