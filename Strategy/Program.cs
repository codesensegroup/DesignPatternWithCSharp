using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var stuctfile = FileFactory.Create(OutFile.FormatType.STRUCT_CLASS);
            stuctfile.GenFile(stuctfile.DecodeExcel());

            var sqlfile = FileFactory.Create(OutFile.FormatType.SQL);
            sqlfile.GenFile(sqlfile.DecodeExcel());
        }
    }
}
