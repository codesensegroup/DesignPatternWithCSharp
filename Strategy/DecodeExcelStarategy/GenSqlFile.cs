using System;

namespace Strategy
{
    public class GenSqlFile : IFile
    {
        public string DecodeExcel()
        {
            var decodeResultStr = "Decode Excel Gen SQL Content";
            Console.WriteLine(decodeResultStr);
            return decodeResultStr;
        }

        public bool GenFile(string content)
        {
            var genFile = true; 
            Console.WriteLine($"Gen .sql File => {genFile}");
            return genFile;
        }
    }
}
