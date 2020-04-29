using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileChecker
{
    public static class FileHandler
    {
        public static string[] GetFileLines(string path)
        {
            path = CheckPathForUnsupportedChars(path);
            return File.ReadAllLines(path);
        }

        private static string CheckPathForUnsupportedChars(string path)
        {
            if (path.Contains("\""))
            {
                path = path.Replace("\"", "");
            }
            return path;
        }

        public static void CreateIfNotExist(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }
        }

        public static void WriteLines(string[] content, string path)
        {
            CreateIfNotExist(path);
            File.WriteAllLines(path, content);
        }
    }
}
