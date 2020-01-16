//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:3.0.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZigBeeNet.Hardware.Ember.Ezsp.Structure
{
    using ZigBeeNet.Hardware.Ember.Internal.Serializer;
    
    
    /// <summary>
    /// Class to implement the Ember Structure " EmberRouteTableEntry ".
    /// A route table entry stores information about the next hop along the route to the destination.
    /// </summary>
    public class EmberRouteTableEntry
    {
        
        /// <summary>
        ///  The short id of the destination. A value of 0xFFFF indicates the entry is unused.
        /// </summary>
        private int _destination;
        
        /// <summary>
        ///  The short id of the next hop to this destination.
        /// </summary>
        private int _nextHop;
        
        /// <summary>
        ///  Indicates whether this entry is active (0), being discovered (1), unused (3), or validating
        /// (4).
        /// </summary>
        private int _status;
        
        /// <summary>
        ///  The number of seconds since this route entry was last used to send a packet.
        /// </summary>
        private int _age;
        
        /// <summary>
        ///  Indicates whether this destination is a High RAM Concentrator (2), a Low RAM Concentrator
        /// (1), or not a concentrator (0).
        /// </summary>
        private int _concentratorType;
        
        /// <summary>
        ///  For a High RAM Concentrator, indicates whether a route record is needed (2), has been sent
        /// (1), or is no long needed (0) because a source routed message from the concentrator has been
        /// received.
        /// </summary>
        private int _routeRecordState;
        
        public EmberRouteTableEntry()
        {
        }
        
        public EmberRouteTableEntry(EzspDeserializer deserializer)
        {
            Deserialize(deserializer);
        }
        
        /// <summary>
        /// The destination to set as <see cref="uint16_t"/> </summary>
        public void SetDestination(int destination)
        {
            _destination = destination;
        }
        
        /// <summary>
        /// The nextHop to set as <see cref="uint16_t"/> </summary>
        public void SetNextHop(int nextHop)
        {
            _nextHop = nextHop;
        }
        
        /// <summary>
        /// The status to set as <see cref="uint8_t"/> </summary>
        public void SetStatus(int status)
        {
            _status = status;
        }
        
        /// <summary>
        /// The age to set as <see cref="uint8_t"/> </summary>
        public void SetAge(int age)
        {
            _age = age;
        }
        
        /// <summary>
        /// The concentratorType to set as <see cref="uint8_t"/> </summary>
        public void SetConcentratorType(int concentratorType)
        {
            _concentratorType = concentratorType;
        }
        
        /// <summary>
        /// The routeRecordState to set as <see cref="uint8_t"/> </summary>
        public void SetRouteRecordState(int routeRecordState)
        {
            _routeRecordState = routeRecordState;
        }
        
        /// <summary>
        ///  The short id of the destination. A value of 0xFFFF indicates the entry is unused.
        /// Return the destination as <see cref="System.Int32"/>
        /// </summary>
        public int GetDestination()
        {
            return _destination;
        }
        
        /// <summary>
        ///  The short id of the next hop to this destination.
        /// Return the nextHop as <see cref="System.Int32"/>
        /// </summary>
        public int GetNextHop()
        {
            return _nextHop;
        }
        
        /// <summary>
        ///  Indicates whether this entry is active (0), being discovered (1), unused (3), or validating
        /// (4).
        /// Return the status as <see cref="System.Int32"/>
        /// </summary>
        public int GetStatus()
        {
            return _status;
        }
        
        /// <summary>
        ///  The number of seconds since this route entry was last used to send a packet.
        /// Return the age as <see cref="System.Int32"/>
        /// </summary>
        public int GetAge()
        {
            return _age;
        }
        
        /// <summary>
        ///  Indicates whether this destination is a High RAM Concentrator (2), a Low RAM Concentrator
        /// (1), or not a concentrator (0).
        /// Return the concentratorType as <see cref="System.Int32"/>
        /// </summary>
        public int GetConcentratorType()
        {
            return _concentratorType;
        }
        
        /// <summary>
        ///  For a High RAM Concentrator, indicates whether a route record is needed (2), has been sent
        /// (1), or is no long needed (0) because a source routed message from the concentrator has been
        /// received.
        /// Return the routeRecordState as <see cref="System.Int32"/>
        /// </summary>
        public int GetRouteRecordState()
        {
            return _routeRecordState;
        }
        
        /// <summary>
        /// Serialise the contents of the EZSP structure. </summary>
        public int[] Serialize(EzspSerializer serializer)
        {
            serializer.SerializeUInt16(_destination);
            serializer.SerializeUInt16(_nextHop);
            serializer.SerializeUInt8(_status);
            serializer.SerializeUInt8(_age);
            serializer.SerializeUInt8(_concentratorType);
            serializer.SerializeUInt8(_routeRecordState);
            return serializer.GetPayload();
        }
        
        /// <summary>
        /// Deserialise the contents of the EZSP structure. </summary>
        public void Deserialize(EzspDeserializer deserializer)
        {
            _destination = deserializer.DeserializeUInt16();
            _nextHop = deserializer.DeserializeUInt16();
            _status = deserializer.DeserializeUInt8();
            _age = deserializer.DeserializeUInt8();
            _concentratorType = deserializer.DeserializeUInt8();
            _routeRecordState = deserializer.DeserializeUInt8();
        }
        
        public override string ToString()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            builder.Append("EmberRouteTableEntry [destination=");
            builder.Append(_destination);
            builder.Append(", nextHop=");
            builder.Append(_nextHop);
            builder.Append(", status=");
            builder.Append(_status);
            builder.Append(", age=");
            builder.Append(_age);
            builder.Append(", concentratorType=");
            builder.Append(_concentratorType);
            builder.Append(", routeRecordState=");
            builder.Append(_routeRecordState);
            builder.Append(']');
            return builder.ToString();
        }
    }
}