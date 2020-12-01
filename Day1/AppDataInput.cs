using System;
using System.Collections.Generic;
using System.IO;

namespace Day1
{
    public class AppDataInput
    {
        readonly string path = @"..\..\..\Data\input.txt";

        public List<string> ReadData()
        {
            List<string> returnString = new List<string>();
            using (StreamReader reader = File.OpenText(path))
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
