using AdventOfCode2020;
using System;
using System.Collections.Generic;
using System.Linq;

AppDataInput inputFile = new AppDataInput();
List<string> dataList = inputFile.ReadData("Day03-input.txt"); //Read data from: "../../AdventOfCode2020/Data/{dataInputFile}"
List <Passport> passportList = new List<Passport>();
int totalNumberOfPassports = 0; 

//Examples:
Passport pass1 = new Passport(860033327, 147, 1937, 2017, 2020, 183, "CM", "#fffffd", "gry");
Passport pass2 = new Passport(028048884, 350, 1929, 2013, 2023, 0, "NONE", "#cfa07d", "amb");
Passport pass3 = new Passport(760753108, 147, 1931, 2013, 2024, 179, "CM", "#ae17e1", "brn");
Passport pass4 = new Passport(166559648, 0, 1937, 2011, 2025, 59, "IN", "#cfa07d", "brn");

passportList.Add(pass1);
passportList.Add(pass2);
passportList.Add(pass3);
passportList.Add(pass4);

ReadPassportBatch();


foreach (var passport in passportList)
{
    Console.WriteLine(passport.pid);
    totalNumberOfPassports++;
}

Console.WriteLine("\nTotal number of passports: " + totalNumberOfPassports);




void ReadPassportBatch()
{
    for (int i = 0; i < dataList.Count; i++)
    {
        if (dataList[i] is not "" || dataList[i] is not null)
        {
            for (int passRow = i; passRow < (i+10); passRow++)
            {
                string[] variables = new string[] { "pid", "cid", "byr", "iyr", "eyr", "hgt", "hgtINCM", "hcl", "ecl" };
                int pid = 0;
                int cid = 0;
                int byr = 0;
                int iyr = 0;
                int eyr = 0;
                int hgt = 0;
                string hgtINCM = "NONE";
                string hcl = "NONE";
                string ecl = "NONE";

                if (dataList[passRow] is not "" || dataList[passRow] is not null)
                {
                    foreach (var variable in variables)
                    {
                        if (dataList[passRow].Contains(variable))
                        {
                            string[] splitted = dataList[passRow].Split(" ");
                            foreach (var item in splitted)
                            {
                                if (item.StartsWith(variable))
                                {
                                    string[] splitting = item.Split(":");

                                    if(variable.Equals("pid"))
                                        pid = int.Parse(splitting[1]);
                                    else if (variable.Equals("cid"))
                                        cid = int.Parse(splitting[1]);
                                    else if (variable.Equals("byr"))
                                        byr = int.Parse(splitting[1]);
                                    else if (variable.Equals("iyr"))
                                        iyr = int.Parse(splitting[1]);
                                    else if (variable.Equals("eyr"))
                                        eyr = int.Parse(splitting[1]);
                                    //else if (variable.Equals("hgt"))
                                    //{
                                    //    //have to splitt value
                                    //    hgt = int.Parse(splitting[1]);
                                    //}
                                    //Can't be checked
                                    //else if (variable.Equals("hgtINCM"))
                                    //    hgtINCM = int.Parse(splitting[1]);
                                    else if (variable.Equals("hcl"))
                                        hcl = splitting[1];
                                    else if (variable.Equals("ecl"))
                                        ecl = splitting[1];
                                }
                            }
                        }
                    }
                }

                Passport passport = new Passport(pid, cid, byr, iyr, eyr, hgt, hgtINCM, hcl, ecl);
                passportList.Add(passport);
            }
        }
    }
}

/// <summary>
///     pid(Passport ID), 
///     cid(Country ID), 
///     byr(Birth Year), 
///     iyr(Issue Year), 
///     eyr(Expiration Year), 
///     hgt(Height), 
///     hcl(Hair Color), 
///     ecl(Eye Color)
/// </summary>
public record Passport(int pid, int cid, int byr, int iyr, int eyr, int hgt, string hgtINCM, string hcl, string ecl);