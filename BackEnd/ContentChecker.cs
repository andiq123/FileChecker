using System;
using System.Collections.Generic;
using System.IO;

namespace FileChecker
{
    public class ContentChecker
    {
        private readonly FileHandler _fileHandler;

        public ContentChecker(FileHandler fileHandler)
        {
            _fileHandler = fileHandler;
        }

        public string[] GetData(int typeProcess)
        {
            if (checkForEmpty())
            {
                string[] fileContent1 = _fileHandler.GetFileLines(1);
                string[] fileContent2 = _fileHandler.GetFileLines(2);
                List<string> items = new List<string>();
                int limitFor = fileContent1.Length > fileContent2.Length ? fileContent1.Length : fileContent2.Length;
                for (int i = 0; i < limitFor; i++)
                {
                    try
                    {
                        var difOrAlike = typeProcess == 0 ? fileContent1[i] != fileContent2[i] : fileContent1[i] == fileContent2[i];
                        var isNotEmptySpace = !string.IsNullOrEmpty(fileContent1[i]) && !string.IsNullOrEmpty(fileContent2[i]);
                        if (difOrAlike && isNotEmptySpace)
                        {
                            var template = $"File1:\n{fileContent1[i]}\nFile2:\n{fileContent2[i]}\n\n";
                            items.Add(template);
                        }
                    }
                    catch (Exception)
                    {
                        return items.ToArray();
                    }
                }
                return items.ToArray();
            }
            throw new Exception("No path Were Setted");
        }


        public void WriteDiferences()
        {
            var diferences = GetData(0);
            var output = GetOutput();
            _fileHandler.WriteLines(diferences, output);
        }

        public void WriteAlikes()
        {
            var diferences = GetData(1);
            var output = GetOutput();
            _fileHandler.WriteLines(diferences, output);
        }

        private string GetOutput()
        {
            var letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            var name = "";
            for (int i = 0; i < 7; i++)
            {
                var randomNr = new Random().Next(0, letters.Length);
                name += letters[randomNr];
            }

            string output;
            var dir1 = Directory.GetParent(_fileHandler.Path1);
            var dir2 = Directory.GetParent(_fileHandler.Path2);

            if (dir1 == dir2)
                output = Path.Combine(dir1.FullName, name);
            else
                output = Path.Combine(Directory.GetCurrentDirectory(), name).ToString();

            output += ".txt";
            return output;
        }

        private bool checkForEmpty()
        {
            return !string.IsNullOrEmpty(_fileHandler.Path1) && !string.IsNullOrEmpty(_fileHandler.Path2);
        }
    }
}
