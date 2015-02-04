using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace advit.shared.DataContracts.Core.Device
{
    [DataContract]
    public class Device : CoreBase
    {
        [DataMember]
        public long RoomId { get; set; }

        [DataMember]
        public string DisplayName { get; set; }

        [DataMember]
        public DeviceType DeviceTypeId { get; set; }

        [DataMember]
        public long InchesOffFloor { get; set; }

    }

    [DataContract]
    public enum DeviceType : int
    {
        [EnumMember]
        SensorContainer = 1,

        [EnumMember]
        Light = 2,

        [EnumMember]
        Lock = 3,

        [EnumMember]
        Switch = 4
        
    }

}
