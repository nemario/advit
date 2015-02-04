using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace advit.shared.DataContracts.Core.Structure
{
    [DataContract]
    public class StructureBase : CoreBase
    {
        //public long UpperLeft = 0;

        [DataMember] //number of squares to the right of UpperLeft
        public long UpperRight { get; set; }

        [DataMember] //number of squares to down from UpperLeft
        public long LowerLeft { get; set; }

        [DataMember]
        public Collection<Coordinate> IncludedSquares { get; set; } //If blank, include all


    }
}
