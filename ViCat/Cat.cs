using System;
using System.Runtime.Serialization;
namespace ViCat
{
    [DataContract]
    public class Cat
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public Genders Gender { get; set; }
        [DataMember]
        public double Age { get; set; }
        [DataMember]
        public Appearance Appearance { get; set; }
        [DataMember]
        public int IndexEating { get; set; }
        [DataMember]
        public int IndexCleanness { get; set; }
        [DataMember]
        public int IndexHappiness { get; set; }
        [DataMember]
        public int IndexTiredness { get; set; }

        private int SetIndex(int index, int size)
        {
            if (index + size >= 100)
            {
                return 100;
            }
            else
            {
                return index + size;
            }
        }
        public void Feed(int size)
        {
            IndexEating = SetIndex(IndexEating, size);
        }
        public void Washing(int size)
        {
            IndexCleanness = SetIndex(IndexCleanness, size);
            IndexTiredness = SetIndex(IndexTiredness, size/2);
        }
        public void Sleep(int size)
        {
            IndexTiredness = SetIndex(IndexTiredness, -size);
        }
        public void Play(int size)
        {
            IndexHappiness = SetIndex(IndexHappiness, size);
            IndexTiredness = SetIndex(IndexTiredness, size);
        }
    }

    [DataContract]
    public enum Genders
    {
        [EnumMember]
        Female,
        [EnumMember]
        Male
    }
}
