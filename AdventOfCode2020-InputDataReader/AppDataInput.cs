using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode2020
{
    public class AppDataInput
    {
        string folderDataPath = @"..\..\..\..\..\AdventOfCode2020-InputDataReader\Data\";

        public List<string> ReadData(string dataInputFile)
        {
            string inputDataPath = folderDataPath + dataInputFile;
            List<string> returnString = new List<string>();
            using (StreamReader reader = File.OpenText(inputDataPath))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    returnString.Add(line);
                }
            }
            return returnString;
        }

        public List<Dictionary<string, string>> ReadKeyValue(string dataInputFile, string separator1, string separator2)
        {
            StreamReader reader = File.OpenText(folderDataPath + dataInputFile);
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            List<Dictionary<string, string>> dictionaryList = new List<Dictionary<string, string>>();
            string row;
            while ((row = reader.ReadLine()) is not null)
            {
                if (row is "")
                {
                    dictionaryList.Add(dictionary);
                    dictionary = new Dictionary<string, string>();
                }
                else
                {
                    string[] splitted = row.Split(separator1).ToArray();
                    foreach (string s in splitted)
                    {
                        string[] ss = s.Split(separator2).ToArray();
                        dictionary[ss[0]] = ss[1];
                    }
                }
            }
            if (dictionary.Count() > 0)
                dictionaryList.Add(dictionary);
            return dictionaryList;
        }
    }
}