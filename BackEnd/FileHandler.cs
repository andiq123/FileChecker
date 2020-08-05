using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileChecker
{
    public class FileHandler
    {
        public string Path1 { get; set; }
        public string Path2 { get; set; }

        public string[] GetFileLines(int pathIndex)
        {
            if (pathIndex == 1 || pathIndex == 2)
            {
                var path = pathIndex == 1 ? Path1 : Path2;
                path = CheckPathForUnsupportedChars(path);
                return File.ReadAllLines(path);
            }
            throw new Exception("miaw");
        }

        private string CheckPathForUnsupportedChars(string path)
        {
            if (path.Contains("\""))
            {
                path = path.Replace("\"", "");
            }
            return path;
        }

        public void CreateIfNotExist(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }
        }

        public void WriteLines(string[] content, string path)
        {
            File.WriteAllLines(path, content);
        }
    }
}
