using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace advit.shared.DataContracts.Core
{
    [DataContract]
    public class CoreBase
    {

        [Key]
        [DataMember]
        [Required]
        public string Id { get; set; }

        [DataMember]
        public string LastModifiedBy { get; set; }

        [DataMember]
        public DateTime? LastModifiedDateTime { get; set; }

        [DataMember]
        [Required]
        public string CreatedBy { get; set; }

        [DataMember]
        [Required]
        public DateTime CreatedDateTime { get; set; }

        [DataMember]
        [Required]
        public string AccountId { get; set; }



    }
}
