using Adapter.Sample;
using Newtonsoft.Json;
using System.Xml;

namespace Adapter.SimpleSample
{
    public class ClassAdapter : IClassManager
    {
        private ClassManager _classManager;

        public ClassAdapter(ClassManager classManager)
        {
            _classManager = classManager;
        }
        

        //Output JsonFormat
        public string GetAllStudents()
        {
            string returnXml = _classManager.GetAllStudents();
            var doc = new XmlDocument();
            doc.LoadXml(returnXml);
            return JsonConvert.SerializeObject(doc, Newtonsoft.Json.Formatting.Indented);
        }
    }
}
