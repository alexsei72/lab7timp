using System;
using System.Xml.Serialization;

namespace App
{

    [Serializable ()]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        [XmlIgnore]
        public string City { get; set; }                           

        [NonSerialized]
        public int Post;                                             

        public Person (string name, int age, string city, int post)
        {
            Name = name;
            Age = age;
            City = city;
            Post = post;
        }

        public Person () { }
    }
}
