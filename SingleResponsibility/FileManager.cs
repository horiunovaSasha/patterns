using System.IO;

namespace SingleResponsibility
{
    public class FileManager
    {
        public void SaveToFile(Journal journal, string fileName, bool overwrite = false)
        {
            if (overwrite || !File.Exists(fileName))
            {
                File.WriteAllText(fileName, journal.ToString());
            }
        }
    }
}