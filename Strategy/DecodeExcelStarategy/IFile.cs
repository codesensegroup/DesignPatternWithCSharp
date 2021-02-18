namespace Strategy
{
    public interface IFile
    {
        string DecodeExcel();
        bool GenFile(string content);
    }
}
