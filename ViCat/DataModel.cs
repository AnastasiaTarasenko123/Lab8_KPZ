using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using ViCat.Serialization;

namespace ViCat
{
    [DataContract]
    public class DataModel
    {
        [DataMember]
        public IEnumerable<User> Users { get; set; }
        [DataMember]
        public IEnumerable<Cat> Cats { get; set; }
        [DataMember]
        public IEnumerable<Appearance> Appearances { get; set; }
        public DataModel()
        {
            Users = new List<User>() { new User() { Username = "Liza" } };
            Cats = new List<Cat>() { new Cat() { Name = "Smyrfic" }, };
            Appearances = new List<Appearance>() { new Appearance() { Color = "white" } };
        }
        public static string DataPath = "vicat.dat";
        public static DataModel Load()
        {
            if(File.Exists(DataPath))
            {
                return DataSerializer.DeserializeItem(DataPath);
            }
            return new DataModel();
        }
        public void Save()
        {
            DataSerializer.SerializerData(DataPath, this);
        }
    }
}
