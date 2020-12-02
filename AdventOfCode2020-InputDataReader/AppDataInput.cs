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
    }
}