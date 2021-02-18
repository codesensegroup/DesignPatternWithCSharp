using System;
using System.Xml.Serialization;

namespace Adapter.Sample
{
    [Serializable]
    public class Student
    {
        [XmlAttribute]
        public int ID { get; set; }
        [XmlAttribute]
        public string Name { get; set; }

        public Student()
        {

        }

        public Student(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
    }
}
