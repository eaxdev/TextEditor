using System.Text;
using System.IO;

namespace TextEditor.BL
{
    public class FileManager
    {
        private readonly Encoding _defaultEncoding = Encoding.GetEncoding(1251);
        public bool IsExist(string filePath)
        {
            bool isExist = File.Exists(filePath);
            return isExist;
        }
        public string GetContent(string filePath)
        {
            return GetContent(filePath, _defaultEncoding);
        }
        public string GetContent(string filePath, Encoding encoding)
        {
            string content = File.ReadAllText(filePath, encoding);
            return content;
        }
        public void SaveContent(string content, string filePath)
        {
            File.WriteAllText(filePath, content, _defaultEncoding);
        }
        public void SaveContent(string content, string filePath, Encoding encoding)
        {
            File.WriteAllText(filePath, content, encoding);
        }
    }
}
