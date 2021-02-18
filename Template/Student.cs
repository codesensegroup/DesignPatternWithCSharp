using System;

namespace Template.Generic
{
    public class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string name, int age)
        {
           Name = name;
            Age = age;
        }

        //Imp IComparable
        public int CompareTo(Student other)
        {
            // Compare word order
            return Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            return $"Name: {Name}\tAge: {Age}";
        }
    }
}
