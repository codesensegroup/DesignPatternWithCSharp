using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Adapter.Sample
{
    public class ClassManager
    {
        public List<Student> students;

        public ClassManager()
        {
            students = new List<Student>();
            this.students.Add(new Student(1, "Spyua"));
            this.students.Add(new Student(2, "Tom"));
            this.students.Add(new Student(3, "Mary"));
        }

        // Output with XmlformatSystem.InvalidOperationException: 'Adapter.Sample.Student cannot be serialized because it does not have a parameterless 
        public virtual string GetAllStudents()
        {
            var emptyNamepsaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            var serializer = new XmlSerializer(students.GetType());
            var settings = new XmlWriterSettings(); settings.Indent = true;
            settings.OmitXmlDeclaration = true;
            using (var stream = new StringWriter())
            using (var writer = XmlWriter.Create(stream, settings))
            {
                serializer.Serialize(writer, students, emptyNamepsaces);
                return stream.ToString();
            }
        }
    }
}
