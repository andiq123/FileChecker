using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileChecker
{
    public static class ContentChecker
    {
        public static string[] GetDiferences(string path1, string path2)
        {
            string[] fileContent1 = FileHandler.GetFileLines(path1);
            string[] fileContent2 = FileHandler.GetFileLines(path2);
            List<string> diferences = new List<string>();
            int limitFor = fileContent1.Length > fileContent2.Length ? fileContent1.Length : fileContent2.Length;
            for (int i = 0; i < limitFor; i++)
            {
                try
                {
                    if (fileContent1[i] != fileContent2[i])
                    {
                        var template = $"File1:\n{fileContent1[i]}\nFile2:\n{fileContent2[i]}\n\n";
                        diferences.Add(template);
                    }

                }
                catch (Exception)
                {
                    return diferences.ToArray();
                }

            }
            return diferences.ToArray();
        }

        public static string[] GetAlikes(string path1, string path2)
        {
            string[] fileContent1 = FileHandler.GetFileLines(path1);
            string[] fileContent2 = FileHandler.GetFileLines(path2);
            List<string> alikes = new List<string>();
            int limitFor = fileContent1.Length > fileContent2.Length ? fileContent1.Length : fileContent2.Length;
            for (int i = 0; i < limitFor; i++)
            {
                try
                {
                    if (fileContent1[i] == fileContent2[i])
                    {
                        var template = $"File1:\n{fileContent1[i]}\nFile2:\n{fileContent2[i]}\n\n";
                        alikes.Add(template);
                    }

                }
                catch (Exception)
                {
                    return alikes.ToArray();
                }
            }
            return alikes.ToArray();
        }

        public static void WriteDiferences(string path1, string path2, string output)
        {
            var diferences = GetDiferences(path1, path2);
            File.WriteAllLines(output, diferences);
        }

        public static void WriteAlikes(string path1, string path2, string output)
        {
            var diferences = GetAlikes(path1, path2);
            File.WriteAllLines(output, diferences);
        }
    }
}
