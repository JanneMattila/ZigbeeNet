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
    /// Class to implement the Ember EZSP command " calculateSmacs283k1Handler ".
    /// A callback to indicate that the NCP has finished calculating the Secure Message
    /// Authentication Codes (SMAC) for both the initiator and responder for the CBKE 283k1
    /// Library. The associated link key is kept in temporary storage until the host tells the NCP to
    /// store or discard the key via emberClearTemporaryDataMaybeStoreLinkKey().
    /// This class provides methods for processing EZSP commands.
    /// </summary>
    public class EzspCalculateSmacs283k1Handler : EzspFrameResponse
    {
        
        public const int FRAME_ID = 235;
        
        /// <summary>
        ///  The result of the CBKE operation.
        /// </summary>
        private EmberStatus _status;
        
        /// <summary>
        ///  The calculated value of the initiators SMAC.
        /// </summary>
        private EmberSmacData _initiatorSmac;
        
        /// <summary>
        ///  The calculated value of the responders SMAC.
        /// </summary>
        private EmberSmacData _responderSmac;
        
        public EzspCalculateSmacs283k1Handler(int[] inputBuffer) : 
                base(inputBuffer)
        {
            _status = deserializer.DeserializeEmberStatus();
            _initiatorSmac = deserializer.DeserializeEmberSmacData();
            _responderSmac = deserializer.DeserializeEmberSmacData();
        }
        
        /// <summary>
        /// The status to set as <see cref="EmberStatus"/> </summary>
        public void SetStatus(EmberStatus status)
        {
            _status = status;
        }
        
        /// <summary>
        /// The initiatorSmac to set as <see cref="EmberSmacData"/> </summary>
        public void SetInitiatorSmac(EmberSmacData initiatorSmac)
        {
            _initiatorSmac = initiatorSmac;
        }
        
        /// <summary>
        /// The responderSmac to set as <see cref="EmberSmacData"/> </summary>
        public void SetResponderSmac(EmberSmacData responderSmac)
        {
            _responderSmac = responderSmac;
        }
        
        /// <summary>
        ///  The result of the CBKE operation.
        /// Return the status as <see cref="EmberStatus"/>
        /// </summary>
        public EmberStatus GetStatus()
        {
            return _status;
        }
        
        /// <summary>
        ///  The calculated value of the initiators SMAC.
        /// Return the initiatorSmac as <see cref="EmberSmacData"/>
        /// </summary>
        public EmberSmacData GetInitiatorSmac()
        {
            return _initiatorSmac;
        }
        
        /// <summary>
        ///  The calculated value of the responders SMAC.
        /// Return the responderSmac as <see cref="EmberSmacData"/>
        /// </summary>
        public EmberSmacData GetResponderSmac()
        {
            return _responderSmac;
        }
        
        public override string ToString()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            builder.Append("EzspCalculateSmacs283k1Handler [status=");
            builder.Append(_status);
            builder.Append(", initiatorSmac=");
            builder.Append(_initiatorSmac);
            builder.Append(", responderSmac=");
            builder.Append(_responderSmac);
            builder.Append(']');
            return builder.ToString();
        }
    }
}