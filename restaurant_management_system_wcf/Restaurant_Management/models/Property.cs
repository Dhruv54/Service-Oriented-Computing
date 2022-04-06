using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Restaurant_Management
{
    [DataContract]
    public class Property
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        [Required]
        public string Name { get; set; }
        [DataMember]
        [Required]
        public string Type { get; set; }
        [DataMember]
        [Required]
        public int Price { get; set; }
        [DataMember]
        [Required]
        public string Location { get; set; }
        [DataMember]
        public string Owner { get; set; }
        //[DataMember]
        //public string ImagePath { get; set; }

    }
}

