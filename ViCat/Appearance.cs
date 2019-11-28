using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ViCat
{
    [DataContract]
    public class Appearance
    {
        [DataMember]
        public string Color { get; set; }
        [DataMember]
        public double Weight { get; set; }
        [DataMember]
        public string Breed { get; set; }
    }
}
