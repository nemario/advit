using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace advit.shared.DataContracts.Core.Structure
{
    [DataContract]
    public class Building : StructureBase
    {

        [DataMember]
        public string DisplayName { get; set; }

        [DataMember]
        public BuildingType BuildingTypeId { get; set; }

        [DataMember]
        public long DimensionId { get; set; }
        
    }

    [DataContract]
    public enum BuildingType : int
    {
        [EnumMember]
        House = 1,

        [EnumMember]
        Garage = 2,

        [EnumMember]
        OutBuilding = 3

    }
}
