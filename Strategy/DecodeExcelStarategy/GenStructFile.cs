using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class GenStructFile : IFile
    {
        public string DecodeExcel()
        {
            var decodeResultStr = "Decode Excel Gen Struct Content";
            Console.WriteLine(decodeResultStr);
            return decodeResultStr;
        }

        public bool GenFile(string content)
        {
            var genFile = true;
            Console.WriteLine($"Gen .cs File => {genFile}");
            return genFile;
        }
    }
}
