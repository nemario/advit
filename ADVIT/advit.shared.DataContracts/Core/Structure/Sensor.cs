using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace advit.shared.DataContracts.Core.Structure
{
    [DataContract]
    public class Sensor
    {
        [DataMember]
        public long DeviceId { get; set; }

        [DataMember]
        public SensorType SensorTypeId { get; set; }

    }

    [DataContract]
    public enum SensorType : int
    {
        [EnumMember]
        Tempature = 10,

        [EnumMember]
        Humidity = 20,

        [EnumMember]
        SmokeCo2 = 30,

        [EnumMember]
        OpenClose = 31,

        [EnumMember]
        Presence = 40,

        [EnumMember]
        Water = 21

    }
}
