using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ViCat
{
    [DataContract]
    public class User
    {
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public List<Cat> Cats { get; set; }
        public void AddCat(Cat cat)
        {
            if(cat != null)
            {
                Cats.Add(cat);
            }
        }
    }
}
