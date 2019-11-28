using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ViCat.Serialization;

namespace ViCat.Test
{
    [TestClass]
    public class UnitTestSerializer
    {
        [TestMethod]
        public void TestMethodSerialize()
        {
            //var model = new DataModel();
            //Appearance appearance = new Appearance("black", 2.3, "none");

            //model.Users = new List<User>() { new User("Kate", "9111") };
            //model.Appearances = new List<Appearance>() { appearance };
            //model.Cats = new List<CatViewModal>() { new CatViewModal("Myrka", "Female", appearance) };

            //DataSerializer.SerializerData(@"D:\vicat.dat", model);
        }

        [TestMethod]
        public void TestMethodDeSerialize()
        {
            var model = DataSerializer.DeserializeItem(@"D:\vicat.dat");
        }
    }
}
