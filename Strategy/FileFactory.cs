namespace Strategy
{
    public class FileFactory
    {
        public static IFile Create(OutFile.FormatType format)
        {
            IFile OFormat = null;
            switch (format)
            {
                //Struct 
                case OutFile.FormatType.STRUCT_CLASS:
                    OFormat = new GenStructFile();
                    break;
                //SQL
                case OutFile.FormatType.SQL:
                    OFormat = new GenSqlFile();
                    break;              
            }

            return OFormat;

        }
    }
}
