using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace advit.shared.DataContracts.Core.Structure
{
    [DataContract]
    public class Layer : StructureBase
    {

        [DataMember]
        public long BuildingId { get; set; }

        [DataMember]
        public string DisplayName { get; set; }

        [DataMember]
        public bool IsSameSizeAsBuilding { get; set; }

        [DataMember]
        public long DimensionId { get; set; }

        [DataMember]
        public decimal ElevationRelatedToGroundLevel { get; set; }

        [DataMember]
        public long CeilingHeightInInches { get; set; }


    }
}
