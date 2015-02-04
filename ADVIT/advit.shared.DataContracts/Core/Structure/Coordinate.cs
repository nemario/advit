using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using advit.shared.DataContracts.Core;


namespace advit.shared.DataContracts.Core.Structure
{
    [DataContract]
    public class Coordinate : CoreBase
    {
        //Always relative to the Upper Object's 0,0

        [DataMember] //number of squares to teh right of UpperLeft
        public long XAxis { get; set; }

        [DataMember] //number of squares to down from UpperLeft
        public long YAxis { get; set; }

    }
}
