using System;
using System.Collections.Generic;
using System.IO;

namespace Solid.Logic
{
    /// <summary>
    /// Single Repository Pattern
    /// </summary>
    public class Diary
    {

        private readonly List<string> entries = new List<string>();
        private int count = 0;

        public int AddEntry(string text)
        {
            entries.Add($"{++count} : {text}");
            return count;
        }

        public bool RemoveEntry(int index)
        {
            bool isRemoved;

            entries.RemoveAt(index);
            isRemoved = true;

            return isRemoved;
        }
        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }

        //Adding more responsibilities like below is a violation of the Single Responsibility Pattern
        //Create a new Class that handles the persistence of things

        public void SaveEntries(string fileName)
        {
            File.WriteAllText(fileName, ToString());
        }

        public void LoadEntries(string filePath)
        {
            File.ReadAllText(filePath);
        }

    }
}
