using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace advit.shared.DataContracts.Core.Structure
{
    [DataContract]
    public class Room : StructureBase
    {

        [DataMember]
        public long LayerId { get; set; }

        [DataMember]
        public string DisplayName { get; set; }
        
        [DataMember]
        public string BaseColor { get; set; }

        [DataMember]
        public long DimensionId { get; set; }

        [DataMember]
        public long CeilingHeightInInches { get; set; }

    }
}
